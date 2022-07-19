using Exp3.Models;
using Exp3.Persistencia;
using Exp3.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Exp3.Controllers
{
    public class BrinquedoController : Controller
    {
        private ParqueDiversaoContext _context;
        private IBrinquedoRepository _brinquedoRepository;

        public BrinquedoController(ParqueDiversaoContext context, IBrinquedoRepository brinquedoRepository)
        {
            _context = context;
            _brinquedoRepository = brinquedoRepository;
        }

        public IActionResult Index(string nomePesquisa, Tipo? tipoPesquisa)
        {
            List<Brinquedo> brinquedos = _brinquedoRepository.BuscarPor(b => (b.Nome.Contains(nomePesquisa) || nomePesquisa == null) && (b.Tipo == tipoPesquisa || tipoPesquisa == null));

            return View(brinquedos);
        }

        public void CarregarManutencao()
        {
            List<Manutencao> manutencao = _context.Manutencoes.OrderBy(m => m.Nome).ToList();
            ViewBag.Manutencao = new SelectList(manutencao, "ManutencaoId", "Nome");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarManutencao();
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Brinquedo brinquedo)
        {
            _brinquedoRepository.Cadastrar(brinquedo);
            _brinquedoRepository.Salvar();
            TempData["msg"] = "Atração cadastrada com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarManutencao();
            Brinquedo brinquedo = _brinquedoRepository.BuscarPorId(id);
            return View(brinquedo);
        }

        [HttpPost]
        public IActionResult Editar(Brinquedo brinquedo)
        {
            _brinquedoRepository.Atualizar(brinquedo);
            _brinquedoRepository.Salvar();
            TempData["msg"] = "Atração editada com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _brinquedoRepository.Remover(id);
            _brinquedoRepository.Salvar();
            TempData["msgDel"] = "Atração removida com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Atividade(int id)
        {
            Brinquedo brinquedo = _brinquedoRepository.BuscarPorId(id);

            List<Colaborador> colaboradores = _context.Colaboradores.ToList();

            ViewBag.colaboradoresSelect = new SelectList(colaboradores, "ColaboradorId", "Nome");

            List<BrinquedoColaborador> brinquedoColaboradores = _context.BrinquedosColaboradores.Where(bc => bc.BrinquedoId == id).Include(bc => bc.Colaborador).ToList();

            ViewBag.colaborador = brinquedoColaboradores;

            return View(brinquedo);
        }

        [HttpPost]
        public IActionResult Adicionar(BrinquedoColaborador brinquedoColaborador)
        {
            _context.BrinquedosColaboradores.Add(brinquedoColaborador);
            _context.SaveChanges();
            TempData["msg"] = "Atividade realizada com sucesso!";

            return RedirectToAction("Atividade", new {id = brinquedoColaborador.BrinquedoId});
        }
    }
}

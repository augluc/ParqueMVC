using Exp3.Models;
using Exp3.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Exp3.Controllers
{
    public class ColaboradorController : Controller
    {
        private static ParqueDiversaoContext _context;

        public ColaboradorController(ParqueDiversaoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Colaborador> colaboradores = _context.Colaboradores.Include(c => c.ContratoTrabalho).ToList();
            return View(colaboradores);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Colaborador colaborador)
        {
            _context.Colaboradores.Add(colaborador);
            _context.SaveChanges();
            TempData["msg"] = "Colaborador cadastrado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            Colaborador colaborador = _context.Colaboradores.Find(id);
            return View(colaborador);
        }

        [HttpPost]
        public IActionResult Editar(Colaborador colaborador)
        {
            _context.Colaboradores.Update(colaborador);
            _context.SaveChanges();
            TempData["msg"] = "Colaborador editado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int ColaboradorId)
        {
            Colaborador colaborador = _context.Colaboradores.Find(ColaboradorId);
            _context.Colaboradores.Remove(colaborador);
            _context.SaveChanges();
            TempData["msgDel"] = "Colaborador removido com sucesso!";
            return RedirectToAction("Index");
        }

    }
}

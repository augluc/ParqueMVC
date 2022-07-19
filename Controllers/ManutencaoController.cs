using Exp3.Models;
using Exp3.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Exp3.Controllers
{
    public class ManutencaoController : Controller
    {
        private static ParqueDiversaoContext _context;

        public ManutencaoController(ParqueDiversaoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.manutencao = _context.Manutencoes.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Manutencao manutencao)
        {
            _context.Manutencoes.Add(manutencao);
            _context.SaveChanges();
            TempData["msg"] = "Manutenção cadastrado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}

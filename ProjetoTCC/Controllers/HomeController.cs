using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetoTCC.Models;

namespace ProjetoTCC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Contexto _context;

        public HomeController(ILogger<HomeController> logger, Contexto contexto)
        {
            _logger = logger;
            _context = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cardapio()
        {
            var categorias = _context.Categorias.Include(c => c.CategoriaPai).Include(p => p.Produtos).ToList();
            return View(categorias);
        }

        public IActionResult QuemSomos()
        {
            return View();
        }

        public IActionResult Fotos()
        {
            return View();
        }
        
    }
}

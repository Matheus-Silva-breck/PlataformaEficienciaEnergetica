using Microsoft.AspNetCore.Mvc;
using PlataformaEficienciaEnergetica.Models;
using PlataformaEficienciaEnergetica.Data;
using System.Diagnostics;


namespace PlataformaEficienciaEnergetica.Controllers
{
    public class HomeController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;

        public IActionResult Index()
        {
            var listaDePredios = _context.Predios.ToList();
            return View(listaDePredios);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
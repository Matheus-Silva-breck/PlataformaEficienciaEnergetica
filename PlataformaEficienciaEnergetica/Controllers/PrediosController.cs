using Microsoft.AspNetCore.Mvc;
using PlataformaEficienciaEnergetica.Models;
using PlataformaEficienciaEnergetica.Data;
using PlataformaEficienciaEnergetica.Repositories;

namespace PlataformaEficienciaEnergetica.Controllers
{
    public class PrediosController(IPredioRepository predioRepository) : Controller
    {
        private readonly IPredioRepository _predioRepository = predioRepository;

        public async Task<IActionResult> Index()
        {
            var predios = await _predioRepository.ObterTodosAsync();
            return View(predios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Predio predio)
        {
            if (ModelState.IsValid)
            {
                await _predioRepository.AdicionarAsync(predio);
                return RedirectToAction(nameof(Index));
            }
            return View(predio);
        }

        public async Task<IActionResult> Deletar(int id)
        {
            var predio = await _predioRepository.ObterPorIdAsync(id);
            if (predio == null)
            {
                return NotFound();
            }
            return View(predio);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmarDelecao(int PredioId)
        {
            await _predioRepository.RemoverAsync(PredioId);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Editar(int id)
        {
            var predio = await _predioRepository.ObterPorIdAsync(id);

            if (predio == null)
            {
                return NotFound();
            }

            return View(predio);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Predio predio)
        {
            if (ModelState.IsValid)
            {
                await _predioRepository.AtualizarAsync(predio);
                return RedirectToAction(nameof(Index));
            }
            return View(predio);
        }
    }
}
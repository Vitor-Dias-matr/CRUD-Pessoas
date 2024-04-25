using CadastroPessoas.Contexto;
using CadastroPessoas.Service.Interface;
using CadastroPessoas.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace CadastroPessoas.Controllers
{
    public class CidadeController : Controller
    {
        private readonly ICidadeService _icidadeService;
        public CidadeController(ICidadeService icidadeService)
        {
            _icidadeService = icidadeService;
        }
        public async Task<IActionResult> Index()
        {
            var cidades = await _icidadeService.GetAllAsync();
            return View(cidades);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CidadeViewModel cidadeViewModel)
        {
            await _icidadeService.Create(cidadeViewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var cidade = await _icidadeService.GetByIdAsync(Id);
            return View(cidade);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CidadeViewModel cidadeViewModel)
        {
            await _icidadeService.UpdateAsync(cidadeViewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            var equipamento = await _icidadeService.GetByIdAsync(Id);
            return View(equipamento);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePorId(int Id)
        {
            try
            {
                await _icidadeService.DeleteAsync(Id);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.ErroExclusao = ex.Message;
                // Retorna diretamente para a view 'Delete'
                return View("Delete", await _icidadeService.GetByIdAsync(Id));
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var cidade = await _icidadeService.GetByIdAsync(id);
            return View(cidade);
        }

    }
}
using AutoMapper;
using CadastroPessoas.Models;
using CadastroPessoas.Service;
using CadastroPessoas.Service.Interface;
using CadastroPessoas.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Controllers
{
    public class RelatorioController : Controller
    {
        public IPessoaService _ipessoaService;
        public IMapper _imapper;
        public ICidadeService _icidadeService;
        public RelatorioController(IPessoaService ipessoaService, IMapper imapper,
            ICidadeService icidadeService)
        {
            _ipessoaService = ipessoaService;
            _imapper = imapper;
            _icidadeService = icidadeService;
        }
        public async Task<IActionResult> Index()
        {
            var listaPessoa = await _ipessoaService.GetAllAsync();

            var pessoa = _imapper.Map<List<PessoaViewModel>>(listaPessoa);

            return View(pessoa);
        } 
         
        public async Task<IActionResult> Modelo2()
        {
            // consulta lista de cidades
            var cidades = await _icidadeService.GetAllAsync();
            ViewBag.Cidades = new SelectList(cidades, "Id", "Nome");

            // Extrai estados únicos das cidades
            var estados = cidades.Select(c => c.Estado).Distinct().ToList();

            // Passa a lista de estados diretamente para a ViewBag
            ViewBag.Estados = estados;

            var listaPessoa = await _ipessoaService.GetAllAsync();

            var pessoa = _imapper.Map<List<PessoaViewModel>>(listaPessoa);

            return View(pessoa);
        }
    }
}

using AutoMapper;
using CadastroPessoas.Contexto;
using CadastroPessoas.Models;
using CadastroPessoas.Repository;
using CadastroPessoas.Service;
using CadastroPessoas.Service.Interface;
using CadastroPessoas.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CadastroPessoas.Models.Enum.Enum;

namespace CadastroPessoas.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaService _ipessoasService;
        private readonly ICidadeService _cidadeService;
        private readonly Context _context;

        public PessoaController(IPessoaService ipessoasService, ICidadeService cidadeService,
            Context context)
        {
            _ipessoasService = ipessoasService;
            _cidadeService = cidadeService;
            _context = context;
        }

        public async Task<IActionResult> Index(string tipo, int cidadeId, string estado)
        {
            try
            {
                // consulta lista de cidades
                var cidades = await _cidadeService.GetAllAsync();
                ViewBag.Cidades = new SelectList(cidades, "Id", "Nome");

                // Extrai estados únicos das cidades
                var estados = cidades.Select(c => c.Estado).Distinct().ToList();

                // Passa a lista de estados diretamente para a ViewBag
                ViewBag.Estados = estados;

                // Obtém todas as pessoas
                var pessoas = await _ipessoasService.GetAllAsync();

                // Filtra as pessoas pelo tipo selecionado, se houver filtro
                if (!string.IsNullOrEmpty(tipo))
                {
                    TipoPessoaEnum tipoFiltrado;
                    if (tipo == "Físicas")
                    {
                        tipoFiltrado = TipoPessoaEnum.CPF;
                    }
                    else if (tipo == "Jurídicas")
                    {
                        tipoFiltrado = TipoPessoaEnum.CNPJ;
                    }
                    else
                    {
                        throw new ArgumentException("Tipo de pessoa inválido.");
                    }

                    pessoas = pessoas.Where(p => p.TipoPessoa == tipoFiltrado);
                }

                // Filtra as pessoas pela cidade selecionada, se houver filtro
                if (cidadeId != 0)
                {
                    pessoas = pessoas.Where(p => p.CidadeId == cidadeId);
                }
                // Filtra as pessoas pelo estado selecionado, se houver filtro
                if (!string.IsNullOrEmpty(estado))
                {
                    pessoas = pessoas.Where(p => p.Cidade.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase));
                }

                // Passa o resultado filtrado para a view
                return View(pessoas.OrderByDescending(x => x.Id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var cidades = await _cidadeService.GetAllAsync();
            ViewBag.Cidades = new SelectList(cidades, "Id", "Nome");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PessoaViewModel pessoaViewModel)
        {
            try
            {
                await _ipessoasService.Create(pessoaViewModel);
                // Retorna um objeto JSON indicando o sucesso
                return Json(new { success = true, redirectUrl = Url.Action("Index") });
            }
            catch (Exception ex)
            {
                var cidades = await _cidadeService.GetAllAsync();
                ViewBag.Cidades = new SelectList(cidades, "Id", "Nome");
                ModelState.AddModelError(string.Empty, ex.Message);
                //return View(pessoaViewModel);
                return Json(new { error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var pessoa = await _ipessoasService.GetByIdAsync(Id);

            var cidades = await _cidadeService.GetAllAsync();
            ViewBag.Cidades = new SelectList(cidades, "Id", "Nome");

            return View(pessoa);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PessoaViewModel pessoaViewModel)
        {
            await _ipessoasService.UpdateAsync(pessoaViewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            var equipamento = await _ipessoasService.GetByIdAsync(Id);
            return View(equipamento);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePorId(int Id)
        {
            await _ipessoasService.DeleteAsync(Id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var cidade = await _ipessoasService.GetByIdAsync(id);
            return View(cidade);
        }
    }
}
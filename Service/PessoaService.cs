using AutoMapper;
using CadastroPessoas.Contexto;
using CadastroPessoas.Models;
using CadastroPessoas.Repository.Interface;
using CadastroPessoas.Service.Interface;
using CadastroPessoas.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CadastroPessoas.Service
{
    public class PessoaService : IPessoaService
    {
        private readonly IMapper _mapper;
        private readonly IPessoaRepository _ipessoaRepository;
        private readonly ICidadeService _cidadeService;
        private readonly Context _context;
        public PessoaService(IMapper mapper, IPessoaRepository ipessoaRepository, Context context,
            ICidadeService cidadeService)
        {
            _mapper = mapper;
            _ipessoaRepository = ipessoaRepository;
            _context = context;
            _cidadeService = cidadeService;
        }

        public async Task Create(PessoaViewModel pessoaViewModel)
        {
            pessoaViewModel.DataCadastro = DateTime.Now;
            var pessoa = _mapper.Map<Pessoa>(pessoaViewModel);

            var verificaCpfCnpj = await ExistePessoaComCpfCnpj(pessoaViewModel.CpfCnpj);

            if (verificaCpfCnpj == true)
                throw new Exception($"{pessoaViewModel.CpfCnpj} já está cadastrado");
            else
                await _ipessoaRepository.AddAsync(pessoa);
        }

        public async Task DeleteAsync(int id)
        {
            await _ipessoaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PessoaViewModel>> GetAllAsync()
        {
            var pessoas = await _ipessoaRepository.GetAllAsync();
            var cidades = await _cidadeService.GetAllAsync();

            foreach (var p in pessoas)
            {
                foreach (var c in cidades)
                {
                    if (p.CidadeId == c.Id)
                        p.Cidade.Nome = c.Nome;
                }
            }

            pessoas.OrderByDescending(x => x.Id);

            var pessoasMap = _mapper.Map<IEnumerable<PessoaViewModel>>(pessoas);
            return pessoasMap;
        }

        public async Task Edit(int id)
        {
            var pessoa = await _ipessoaRepository.GetByIdAsync(id);
            await _ipessoaRepository.UpdateAsync(pessoa);
        }

        public async Task<PessoaViewModel> GetByIdAsync(int id)
        {
            var pessoa = await _ipessoaRepository.GetByIdAsync(id);
            var pessoaMap = _mapper.Map<PessoaViewModel>(pessoa);

            return pessoaMap;
        }

        public async Task UpdateAsync(PessoaViewModel pessoaViewModel)
        {
            var pessoaMap = _mapper.Map<Pessoa>(pessoaViewModel);
            await _ipessoaRepository.UpdateAsync(pessoaMap);
        }

        public async Task<bool> ExistePessoaComCpfCnpj(string cpfCnpj)
        {

            return await _context.Pessoas.AnyAsync(p => p.CpfCnpj == cpfCnpj);

        }

        public async Task<string> ConsultaEnderecoCEP(string cep)
        {
            try
            {
                var client = new RestClient($"https://viacep.com.br/ws/{cep}/json");

                var request = new RestRequest();
                var response = await client.GetAsync(request);
                var json = response.Content;
                return json;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

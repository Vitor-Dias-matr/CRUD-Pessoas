using AutoMapper;
using CadastroPessoas.Contexto;
using CadastroPessoas.Models;
using CadastroPessoas.Repository.Interface;
using CadastroPessoas.Service.Interface;
using CadastroPessoas.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Service
{
    public class CidadeService : ICidadeService
    {
        private readonly IMapper _mapper;
        private readonly ICidadeRepository _icidadeRepository;
        private readonly Context _context;
        public CidadeService(IMapper mapper, ICidadeRepository icidadeRepository, Context context)
        {
            _mapper = mapper;
            _icidadeRepository = icidadeRepository;
            _context = context;
        }

        public async Task Create(CidadeViewModel cidadeViewModel)
        {
            var cidade = _mapper.Map<Cidade>(cidadeViewModel);
            await _icidadeRepository.AddAsync(cidade);
        }

        public async Task DeleteAsync(int id)
        { 
            var verificaExcluirCidade = await verificaSeExistePessoaRelacionadaACidade(id);
            if (verificaExcluirCidade ==  true)
            {
                throw new Exception($"Não é possível excluir esta cidade pois está relacionada a uma ou mais pessoas.");
            }
            await _icidadeRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CidadeViewModel>> GetAllAsync()
        {
            var cidades = await _icidadeRepository.GetAllAsync();
            var cidadesMap = _mapper.Map<IEnumerable<CidadeViewModel>>(cidades);
            return cidadesMap;
        }

        public async Task Edit(int id)
        {
            var cidade = await _icidadeRepository.GetByIdAsync(id);
            await _icidadeRepository.UpdateAsync(cidade);
        }

        public async Task<CidadeViewModel> GetByIdAsync(int id)
        {
            var cidade = await _icidadeRepository.GetByIdAsync(id);
            var cidadeMap = _mapper.Map<CidadeViewModel>(cidade);
            return cidadeMap;
        }

        public async Task UpdateAsync(CidadeViewModel cidadeViewModel)
        {
            var cidadeMap = _mapper.Map<Cidade>(cidadeViewModel);
            await _icidadeRepository.UpdateAsync(cidadeMap);
        }

        public async Task<bool> verificaSeExistePessoaRelacionadaACidade(int idCidade)
        {
            return await _context.Pessoas.AnyAsync(p => p.CidadeId == idCidade);
        }
    }
}
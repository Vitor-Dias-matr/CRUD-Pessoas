using AutoMapper;
using CadastroPessoas.Models;
using CadastroPessoas.ViewModel;
using System.Collections.Generic;

namespace CadastroPessoas.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pessoa, PessoaViewModel>(); 
            CreateMap<PessoaViewModel, Pessoa>();

            CreateMap<Cidade, CidadeViewModel>();
            CreateMap<CidadeViewModel, Cidade>();

        }
    }
}
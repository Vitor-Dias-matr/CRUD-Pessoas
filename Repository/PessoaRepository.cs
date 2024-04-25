using CadastroPessoas.Contexto;
using CadastroPessoas.Models;
using CadastroPessoas.Service;
using CadastroPessoas.Service.Interface;
using CadastroPessoas.ViewModel;

namespace CadastroPessoas.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(Context context) : base(context) 
        {
                 
        }
        
    }
}

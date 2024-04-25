using CadastroPessoas.Models;
using CadastroPessoas.Service.Interface;
using CadastroPessoas.Service;
using CadastroPessoas.Repository.Interface;
using CadastroPessoas.Contexto;

namespace CadastroPessoas.Repository
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(Context context) : base(context)
        {

        }
    }
}

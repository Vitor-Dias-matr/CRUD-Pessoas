using CadastroPessoas.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroPessoas.Service.Interface
{
    public interface IPessoaService
    {
        Task Create(PessoaViewModel pessoaViewModel);
        Task<IEnumerable<PessoaViewModel>> GetAllAsync();
        Task UpdateAsync(PessoaViewModel cidadeViewModel);
        Task DeleteAsync(int id);
        Task<PessoaViewModel> GetByIdAsync(int id);
    } 
}
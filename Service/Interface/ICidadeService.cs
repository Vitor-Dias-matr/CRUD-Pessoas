using CadastroPessoas.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroPessoas.Service.Interface
{
    public interface ICidadeService
    {
        Task Create(CidadeViewModel cidadeViewModel);
        Task<IEnumerable<CidadeViewModel>> GetAllAsync();
        Task UpdateAsync(CidadeViewModel cidadeViewModel); 
        Task DeleteAsync(int id);
        Task<CidadeViewModel> GetByIdAsync(int id); 
    }
}

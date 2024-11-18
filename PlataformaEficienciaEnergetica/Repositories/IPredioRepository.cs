// Repositories/IPredioRepository.cs
using PlataformaEficienciaEnergetica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlataformaEficienciaEnergetica.Repositories
{
    public interface IPredioRepository
    {
        Task<IEnumerable<Predio>> ObterTodosAsync();
        Task<Predio?> ObterPorIdAsync(int id);  
        Task AdicionarAsync(Predio predio);
        Task AtualizarAsync(Predio predio);
        Task RemoverAsync(int id);
    }
}

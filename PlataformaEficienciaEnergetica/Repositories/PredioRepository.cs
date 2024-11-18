// Repositories/PredioRepository.cs
using Microsoft.EntityFrameworkCore;
using PlataformaEficienciaEnergetica.Data;
using PlataformaEficienciaEnergetica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlataformaEficienciaEnergetica.Repositories
{
    public class PredioRepository(AppDbContext context) : IPredioRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Predio>> ObterTodosAsync()
        {
            return await _context.Predios.ToListAsync();
        }

        public async Task<Predio?> ObterPorIdAsync(int id)
        {
            return await _context.Predios.FindAsync(id);
        }

        public async Task AdicionarAsync(Predio predio)
        {
            await _context.Predios.AddAsync(predio);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Predio predio)
        {
            _context.Predios.Update(predio);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverAsync(int id)
        {
            var predio = await _context.Predios.FindAsync(id);
            if (predio != null)
            {
                _context.Predios.Remove(predio);
                await _context.SaveChangesAsync();
            }
        }
    }
}

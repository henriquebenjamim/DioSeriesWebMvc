using DioSeriesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DioSeriesWebMvc.Services.Exceptions;

namespace DioSeriesWebMvc.Services
{
    public class GymmingService
    {
        // adicionando a dependencia ao dbcontext(DioSeriesWebMvcContext
        private readonly DioSeriesWebMvcContext _context;

        public GymmingService(DioSeriesWebMvcContext context)
        {
            _context = context;
        }

        // retorna uma lista com todas as pessoas que treinam
        public async Task<List<Gymming>> FindAllAsync() 
        {
            return await _context.Gymming.ToListAsync();
        }

        public async Task InsertAsync(Gymming obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Gymming> FindByIdAsync(int id)
        {   

            return await _context.Gymming.Include(obj => obj.GymDepartment).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Gymming.FindAsync(id);
            _context.Gymming.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Gymming obj)
        {
            bool hasAny = await _context.Gymming.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found!");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}

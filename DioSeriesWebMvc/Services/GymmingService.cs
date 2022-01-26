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
        public List<Gymming> FindAll() 
        {
            return _context.Gymming.ToList();
        }

        public void Insert(Gymming obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Gymming FindById(int id)
        {   

            return _context.Gymming.Include(obj => obj.GymDepartment).FirstOrDefault(obj => obj.Id == id);
        }
        
        public void Remove(int id)
        {
            var obj = _context.Gymming.Find(id);
            _context.Gymming.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Gymming obj)
        {
            if(!_context.Gymming.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found!");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}

using DioSeriesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}

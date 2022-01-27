using DioSeriesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DioSeriesWebMvc.Services
{
    public class GymDepartmentService
    {
        private readonly DioSeriesWebMvcContext _context;

        public GymDepartmentService(DioSeriesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<GymDepartment>> FindAllAsync()
        {
            return await _context.GymDepartment.OrderBy(x => x.Name).ToListAsync();
        }
    }
}

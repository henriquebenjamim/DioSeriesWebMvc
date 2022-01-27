using DioSeriesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DioSeriesWebMvc.Services
{
    public class GymmingRecordService
    {
        private readonly DioSeriesWebMvcContext _context;

        public GymmingRecordService(DioSeriesWebMvcContext context)
        {
            _context = context;
        }

         public async Task<List<GymmingRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
         {
            var result = from obj in _context.GymmingRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Gymming)
                .Include(x => x.Gymming.GymDepartment)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
         }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DioSeriesWebMvc.Models
{
    public class DioSeriesWebMvcContext : DbContext
    {
        public DioSeriesWebMvcContext (DbContextOptions<DioSeriesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<DioSeriesWebMvc.Models.GymDepartment> GymDepartment { get; set; }
    }
}

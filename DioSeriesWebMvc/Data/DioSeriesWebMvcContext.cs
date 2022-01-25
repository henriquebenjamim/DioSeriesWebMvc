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

        public DbSet<GymDepartment> GymDepartment { get; set; }
        public DbSet<Gymming> Gymming { get; set; }
        public DbSet<GymmingRecord> GymmingRecord { get; set; }
    }
}

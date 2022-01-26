using DioSeriesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DioSeriesWebMvc.Services
{
    public class GymDepartmentService
    {
        private readonly DioSeriesWebMvcContext _context;

        public GymDepartmentService(DioSeriesWebMvcContext context)
        {
            _context = context;
        }

        public List<GymDepartment> FindAll()
        {
            return _context.GymDepartment.OrderBy(x => x.Name).ToList();
        }
    }
}

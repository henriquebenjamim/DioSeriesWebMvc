using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DioSeriesWebMvc.Models;

namespace DioSeriesWebMvc.Controllers
{
    public class GymDepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<GymDepartment> list = new List<GymDepartment>();
            list.Add(new GymDepartment { Id = 1, Name = "Arthur Lundgren 1" });
            list.Add(new GymDepartment { Id = 2, Name = "Jardim Paulista baixo" });

            return View(list);
        }
    }
}

using DioSeriesWebMvc.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesWebMvc.Controllers
{
    public class GymmingsController : Controller
    {
        private readonly GymmingService _gymmingService;
        
        public GymmingsController(GymmingService gymmingService) 
        {
            _gymmingService = gymmingService;
        }
        public IActionResult Index()
        {
            var list = _gymmingService.FindAll();
            return View(list);
        }
    }
}

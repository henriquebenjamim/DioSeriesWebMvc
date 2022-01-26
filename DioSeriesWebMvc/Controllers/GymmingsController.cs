using DioSeriesWebMvc.Models;
using DioSeriesWebMvc.Models.ViewModels;
using DioSeriesWebMvc.Services;
using DioSeriesWebMvc.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesWebMvc.Controllers
{
    public class GymmingsController : Controller
    {
        private readonly GymmingService _gymmingService;
        private readonly GymDepartmentService _gymDepartmentService;

        public GymmingsController(GymmingService gymmingService, GymDepartmentService gymDepartmentService)
        {
            _gymmingService = gymmingService;
            _gymDepartmentService = gymDepartmentService;
        }
        public IActionResult Index()
        {
            var list = _gymmingService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var gymDeparments = _gymDepartmentService.FindAll();
            var viewModel = new GymmingFormViewModel { GymDepartments = gymDeparments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Gymming gymming)
        {
            if (!ModelState.IsValid)
            {
                var gymDepartments = _gymDepartmentService.FindAll();
                var viewModel = new GymmingFormViewModel { Gymming = gymming, GymDepartments = gymDepartments };
                return View(viewModel);
            }
            _gymmingService.Insert(gymming);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not orovided"});
            }
            
            var obj = _gymmingService.FindById(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _gymmingService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = _gymmingService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        public IActionResult Edit(int? id) 
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = _gymmingService.FindById(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<GymDepartment> gymDepartments = _gymDepartmentService.FindAll();
            GymmingFormViewModel viewModel = new GymmingFormViewModel { Gymming = obj, GymDepartments = gymDepartments };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Gymming gymming)
        {
            if (!ModelState.IsValid)
            {
                var gymDepartments = _gymDepartmentService.FindAll();
                var viewModel = new GymmingFormViewModel { Gymming = gymming, GymDepartments = gymDepartments };
                return View(viewModel);
            }
            if (id != gymming.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                _gymmingService.Update(gymming);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}

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
        public async Task<IActionResult> Index()
        {
            var list = await _gymmingService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var gymDeparments = await _gymDepartmentService.FindAllAsync();
            var viewModel = new GymmingFormViewModel { GymDepartments = gymDeparments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Gymming gymming)
        {
            if (!ModelState.IsValid)
            {
                var gymDepartments = await _gymDepartmentService.FindAllAsync();
                var viewModel = new GymmingFormViewModel { Gymming = gymming, GymDepartments = gymDepartments };
                return View(viewModel);
            }
            await _gymmingService.InsertAsync(gymming);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not orovided"});
            }
            
            var obj = await _gymmingService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _gymmingService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e )
            {
                return RedirectToAction(nameof(Error), new { message = e.Message }) ;
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _gymmingService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id) 
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _gymmingService.FindByIdAsync(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<GymDepartment> gymDepartments = await _gymDepartmentService.FindAllAsync();
            GymmingFormViewModel viewModel = new GymmingFormViewModel { Gymming = obj, GymDepartments = gymDepartments };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Gymming gymming)
        {
            if (!ModelState.IsValid)
            {
                var gymDepartments = await _gymDepartmentService.FindAllAsync();
                var viewModel = new GymmingFormViewModel { Gymming = gymming, GymDepartments = gymDepartments };
                return View(viewModel);
            }
            if (id != gymming.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                await _gymmingService.UpdateAsync(gymming);
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

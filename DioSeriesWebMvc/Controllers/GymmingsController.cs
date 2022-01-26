﻿using DioSeriesWebMvc.Models;
using DioSeriesWebMvc.Models.ViewModels;
using DioSeriesWebMvc.Services;
using DioSeriesWebMvc.Services.Exceptions;
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
            _gymmingService.Insert(gymming);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            
            var obj = _gymmingService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
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
                return NotFound();
            }

            var obj = _gymmingService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Edit(int? id) 
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _gymmingService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            List<GymDepartment> gymDepartments = _gymDepartmentService.FindAll();
            GymmingFormViewModel viewModel = new GymmingFormViewModel { Gymming = obj, GymDepartments = gymDepartments };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Gymming gymming)
        {
            if (id != gymming.Id)
            {
                return BadRequest();
            }
            try
            {
                _gymmingService.Update(gymming);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}

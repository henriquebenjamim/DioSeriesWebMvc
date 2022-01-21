using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DioSeriesWebMvc.Models;

namespace DioSeriesWebMvc.Controllers
{
    public class GymDepartmentsController : Controller
    {
        private readonly DioSeriesWebMvcContext _context;

        public GymDepartmentsController(DioSeriesWebMvcContext context)
        {
            _context = context;
        }

        // GET: GymDepartments
        public async Task<IActionResult> Index()
        {
            return View(await _context.GymDepartment.ToListAsync());
        }

        // GET: GymDepartments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymDepartment = await _context.GymDepartment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gymDepartment == null)
            {
                return NotFound();
            }

            return View(gymDepartment);
        }

        // GET: GymDepartments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GymDepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] GymDepartment gymDepartment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gymDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gymDepartment);
        }

        // GET: GymDepartments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymDepartment = await _context.GymDepartment.FindAsync(id);
            if (gymDepartment == null)
            {
                return NotFound();
            }
            return View(gymDepartment);
        }

        // POST: GymDepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] GymDepartment gymDepartment)
        {
            if (id != gymDepartment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gymDepartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GymDepartmentExists(gymDepartment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gymDepartment);
        }

        // GET: GymDepartments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymDepartment = await _context.GymDepartment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gymDepartment == null)
            {
                return NotFound();
            }

            return View(gymDepartment);
        }

        // POST: GymDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gymDepartment = await _context.GymDepartment.FindAsync(id);
            _context.GymDepartment.Remove(gymDepartment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GymDepartmentExists(int id)
        {
            return _context.GymDepartment.Any(e => e.Id == id);
        }
    }
}

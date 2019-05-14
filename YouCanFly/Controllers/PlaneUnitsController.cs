using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YouCanFly.Models;

namespace YouCanFly.Controllers
{
    public class PlaneUnitsController : Controller
    {
        private readonly YouCanFlyContext _context;

        public PlaneUnitsController(YouCanFlyContext context)
        {
            _context = context;
        }

        // GET: PlaneUnits
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlaneUnit.ToListAsync());
        }

        // GET: PlaneUnits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeUnit = await _context.PlaneUnit
                .SingleOrDefaultAsync(m => m.PlanesId == id);
            if (planeUnit == null)
            {
                return NotFound();
            }

            return View(planeUnit);
        }

        // GET: PlaneUnits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlaneUnits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlanesId,ClassesId")] PlaneUnit planeUnit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planeUnit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planeUnit);
        }

        // GET: PlaneUnits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeUnit = await _context.PlaneUnit.SingleOrDefaultAsync(m => m.PlanesId == id);
            if (planeUnit == null)
            {
                return NotFound();
            }
            return View(planeUnit);
        }

        // POST: PlaneUnits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlanesId,ClassesId")] PlaneUnit planeUnit)
        {
            if (id != planeUnit.PlanesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planeUnit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaneUnitExists(planeUnit.PlanesId))
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
            return View(planeUnit);
        }

        // GET: PlaneUnits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeUnit = await _context.PlaneUnit
                .SingleOrDefaultAsync(m => m.PlanesId == id);
            if (planeUnit == null)
            {
                return NotFound();
            }

            return View(planeUnit);
        }

        // POST: PlaneUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planeUnit = await _context.PlaneUnit.SingleOrDefaultAsync(m => m.PlanesId == id);
            _context.PlaneUnit.Remove(planeUnit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaneUnitExists(int id)
        {
            return _context.PlaneUnit.Any(e => e.PlanesId == id);
        }
    }
}

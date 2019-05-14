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
    public class ClassesController : Controller
    {
        private readonly YouCanFlyContext _context;

        public ClassesController(YouCanFlyContext context)
        {
            _context = context;
        }

        // GET: Classes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Classes.ToListAsync());
        }

        // GET: Classes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classes = await _context.Classes
                .SingleOrDefaultAsync(m => m.Name == id);
            if (classes == null)
            {
                return NotFound();
            }

            return View(classes);
        }

        // GET: Classes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Classes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,ExtraPrice")] Classes classes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classes);
        }

        // GET: Classes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classes = await _context.Classes.SingleOrDefaultAsync(m => m.Name == id);
            if (classes == null)
            {
                return NotFound();
            }
            return View(classes);
        }

        // POST: Classes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Name,ExtraPrice")] Classes classes)
        {
            if (id != classes.Name)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassesExists(classes.Name))
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
            return View(classes);
        }

        // GET: Classes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classes = await _context.Classes
                .SingleOrDefaultAsync(m => m.Name == id);
            if (classes == null)
            {
                return NotFound();
            }

            return View(classes);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var classes = await _context.Classes.SingleOrDefaultAsync(m => m.Name == id);
            _context.Classes.Remove(classes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassesExists(string id)
        {
            return _context.Classes.Any(e => e.Name == id);
        }
    }
}

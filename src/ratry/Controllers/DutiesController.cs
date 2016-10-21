using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ratry.Data;
using ratry.Models;

namespace ratry.Controllers
{
    public class DutiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DutiesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Duties
        public async Task<IActionResult> Index()
        {
            return View(await _context.Duty.ToListAsync());
        }

        // GET: Duties/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duty = await _context.Duty.SingleOrDefaultAsync(m => m.DutyId == id);
            if (duty == null)
            {
                return NotFound();
            }

            return View(duty);
        }

        // GET: Duties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Duties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DutyId,day,hour,name")] Duty duty)
        {
            if (ModelState.IsValid)
            {
                duty.DutyId = Guid.NewGuid();
                _context.Add(duty);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(duty);
        }

        // GET: Duties/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duty = await _context.Duty.SingleOrDefaultAsync(m => m.DutyId == id);
            if (duty == null)
            {
                return NotFound();
            }
            return View(duty);
        }

        // POST: Duties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DutyId,day,hour,name")] Duty duty)
        {
            if (id != duty.DutyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DutyExists(duty.DutyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(duty);
        }

        // GET: Duties/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duty = await _context.Duty.SingleOrDefaultAsync(m => m.DutyId == id);
            if (duty == null)
            {
                return NotFound();
            }

            return View(duty);
        }

        // POST: Duties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var duty = await _context.Duty.SingleOrDefaultAsync(m => m.DutyId == id);
            _context.Duty.Remove(duty);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DutyExists(Guid id)
        {
            return _context.Duty.Any(e => e.DutyId == id);
        }
    }
}

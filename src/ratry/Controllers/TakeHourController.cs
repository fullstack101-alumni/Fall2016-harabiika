using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ratry.Data;
using ratry.Models;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ratry.Controllers
{
    public class TakeHourController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TakeHourController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DutyId,day,hour,name")] Duty duty)
        {
            if (ModelState.IsValid)
            {
                duty.DutyId = Guid.NewGuid();
                duty.name = User.FindFirst(ClaimTypes.GivenName).Value;
                _context.Add(duty);
                await _context.SaveChangesAsync();
                return RedirectToRoute(new { controller = "Manage", action = "Index" });
            }
            return View(duty);
        }
    }
}


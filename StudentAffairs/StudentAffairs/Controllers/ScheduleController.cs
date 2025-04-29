using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAffairs.Models;

namespace StudentAffairs.Controllers
{
    [Authorize]
    public class ScheduleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Lectures()
        {
            var lectures = await _context.Lectures
                .OrderBy(l => l.DayOfWeek)
                .ThenBy(l => l.StartTime)
                .ToListAsync();
            return View(lectures);
        }

        public async Task<IActionResult> Sections()
        {
            var sections = await _context.Sections
                .OrderBy(s => s.DayOfWeek)
                .ThenBy(s => s.StartTime)
                .ToListAsync();
            return View(sections);
        }
    }
} 
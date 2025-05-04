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
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);
            var lectures = await _context.Lectures
                .Where(l => l.StudentYear == user.StudentYear)
                .OrderBy(l => l.DayOfWeek)
                .ThenBy(l => l.StartTime)
                .ToListAsync();
            return View(lectures);
        }

        public async Task<IActionResult> Sections()
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);
            var sections = await _context.Sections
                .Where(s => s.StudentYear == user.StudentYear)
                .OrderBy(s => s.DayOfWeek)
                .ThenBy(s => s.StartTime)
                .ToListAsync();
            return View(sections);
        }
    }
} 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAffairs.Models;

namespace StudentAffairs.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }



        public async Task<IActionResult> ManageLectures()
        {
            var lectures = await _context.Lectures.ToListAsync();
            return View(lectures);
        }

        public async Task<IActionResult> ManageSections()
        {
            var sections = await _context.Sections.ToListAsync();
            return View(sections);
        }

        [HttpGet]
        public IActionResult CreateLecture()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLecture(Lecture lecture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lecture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManageLectures));
            }
            return View(lecture);
        }

        [HttpGet]
        public IActionResult CreateSection()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSection(Section section)
        {
            if (ModelState.IsValid)
            {
                _context.Add(section);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManageSections));
            }
            return View(section);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteLecture(int id)
        {
            var lecture = await _context.Lectures.FindAsync(id);
            if (lecture != null)
            {
                _context.Lectures.Remove(lecture);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ManageLectures));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSection(int id)
        {
            var section = await _context.Sections.FindAsync(id);
            if (section != null)
            {
                _context.Sections.Remove(section);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ManageSections));
        }
    }
} 
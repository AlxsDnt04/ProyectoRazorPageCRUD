using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoRazor.Data;
using ProyectoRazor.Models;

namespace ProyectoRazor.Pages.Enrollments
{
    public class CreateModel : PageModel
    {
        private readonly ProyectoRazor.Data.UniversityContext _context;

        public CreateModel(ProyectoRazor.Data.UniversityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Title");
        ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FullName");
            return Page();
        }

        [BindProperty]
        public Enrollment Enrollment { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enrollments.Add(Enrollment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

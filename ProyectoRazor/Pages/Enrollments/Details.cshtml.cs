using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoRazor.Data;
using ProyectoRazor.Models;

namespace ProyectoRazor.Pages.Enrollments
{
    public class DetailsModel : PageModel
    {
        private readonly ProyectoRazor.Data.UniversityContext _context;

        public DetailsModel(ProyectoRazor.Data.UniversityContext context)
        {
            _context = context;
        }

        public Enrollment Enrollment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollments.FirstOrDefaultAsync(m => m.Id == id);

            if (enrollment is not null)
            {
                Enrollment = enrollment;

                return Page();
            }

            return NotFound();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoRazor.Data;
using ProyectoRazor.Models;

namespace ProyectoRazor.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ProyectoRazor.Data.UniversityContext _context;

        public IndexModel(ProyectoRazor.Data.UniversityContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students
                .Include(s => s.Enrollments)
                .ThenInclude(e => e.Course)
                .ToListAsync();
        }
    }
}

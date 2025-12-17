using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoRazor.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Display(Name = "Título")]
        public string Title { get; set; }
        [Display(Name = "Créditos")]
        public int Credits { get; set; }

        // Relación 1 a muchos
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
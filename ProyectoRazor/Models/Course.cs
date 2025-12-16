using System.Collections.Generic;

namespace ProyectoRazor.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // Relación 1 a muchos
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
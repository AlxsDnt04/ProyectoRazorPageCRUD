using System.ComponentModel.DataAnnotations;

namespace ProyectoRazor.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        // FK hacia Student
        public int StudentId { get; set; }
        [Display(Name = "Estudiante")]
        public Student Student { get; set; }

        // FK hacia Course
        public int CourseId { get; set; }
        [Display(Name = "Curso")]
        public Course Course { get; set; }
        [Display(Name = "Calificación")]
        public string Grade { get; set; }
    }
}
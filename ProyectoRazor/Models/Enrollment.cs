namespace ProyectoRazor.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        // FK hacia Student
        public int StudentId { get; set; }
        public Student Student { get; set; }

        // FK hacia Course
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string Grade { get; set; }
    }
}
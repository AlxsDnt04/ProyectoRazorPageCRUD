using System;
using System.Collections.Generic;
// Necesario para DataType.Date
using System.ComponentModel.DataAnnotations;

namespace ProyectoRazor.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Display(Name = "Fecha de Inscripción")]
        [DataType(DataType.Date)] // Recomendado para que el navegador muestre un calendario
        public DateTime EnrollmentDate { get; set; }

        // Relación 1 a muchos
        public ICollection<Enrollment> Enrollments { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
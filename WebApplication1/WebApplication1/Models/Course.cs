using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Course
    
    {
        
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public int? Credits { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
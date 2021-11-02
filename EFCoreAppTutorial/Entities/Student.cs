using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAppTutorial.Entities
{
   [Table("Student")]
    public class Student
    
    {[Key]
        [Column("StudentId")]
        public Guid StudentId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Length must be less than 50 characters")]
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsRegularStudent { get; set; }
    }
}
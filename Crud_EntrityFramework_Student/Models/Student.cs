using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_EntrityFramework_Student.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        [Required]

        public string? Sname { get; set; }
        [Required]

        public decimal Marks { get; set; }
        [ScaffoldColumn(false)]

        public int IsActive { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace assessment15_.Models
{
    [Table("Student")]
    public class Student
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [StringLength(50)]
            public string Name { get; set; }
            [Required]
            [StringLength(50)]
            public string Designation { get; set; }
            public DateTime DueDate { get; set; }
        }
}

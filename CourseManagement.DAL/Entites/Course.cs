using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CourseManagement.DAL.Entites
{

    public class Course
    {
       public int Id { get; set; }

[Required]
[StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
//[NoNumber]
public string Name { get; set; }

[Required(ErrorMessage = "Category is required")]
public string Category { get; set; }

public string? Description { get; set; }

// FK
[Required]
public int InstructorId { get; set; }

[ForeignKey("InstructorId")]
public Instructor Instructor { get; set; }
    
    }
}


namespace SchoolAppCoreMVC.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        

        public required string Title { get; set; }
        

        public int Credits { get; set; }
       

        public int DepartmentID { get; set; }
       

        // Navigation properties
        public Department? Department { get; set; }
 

        public ICollection<Enrollment>? Enrollments { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using Web_Application__Model_View_Controller__.Views.Shared.Models;
namespace SchoolAppCoreMVC.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public required string LastName
        {
            get; set;
        }
        public required string FirstName
        {
            get; set;
        }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment>? Enrollments
        { get; set; }
    }
}
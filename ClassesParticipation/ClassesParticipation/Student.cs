//Chrissy Stroud

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParticipation
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public List<Course> Courses { get; }

        public Student()
        {
            //fill out default values
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentID = 0;

            Courses = new List<Course>(); //Create our new list
        }
        public void AddCourse(course, Course)
        {
            course = Course;
        }

            
    }
}

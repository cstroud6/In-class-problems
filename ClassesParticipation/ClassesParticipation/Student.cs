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
            //fill out normal default values
            Student fname = new Student();
            Student lname = new Student();
            Student SID = new Student();

            Courses = new List<Course>(); //Create our new list
        }

            
    }
}

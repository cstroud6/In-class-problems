//Chrissy Stroud

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParticipation
{
    class Course

    {
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }

        public Course()
        {
            CourseID = 0;
            CourseNumber = 0;
            CourseName = "";
            Subject = "";
            Instructor = "";
        }

        public string ToString()
        {
            return "";
        }
    }
}

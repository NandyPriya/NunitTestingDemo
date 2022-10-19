using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseUnitTestingDemo
{
    public enum Coursename
    {
        AIML, Dotnet, Java
    }
    public class student
        {
        public int Rollno { get; set; }

        public string Name { get; set; }

        public string Coursename { get; set; }

        public Coursename coursename { get; set; }
    }
    public class Enrollment
    {
        public int Fees { get; set; }
        public int Enrollno { get; set; }

    }
    public class StudentEnrollment
    {
        public bool Enrollstudent(student s, Enrollment e)
        {
            if (e.Fees > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

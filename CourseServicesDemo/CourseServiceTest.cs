using CourseUnitTestingDemo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServicesDemo
{
    [TestFixture]
    public class CourseServiceTest
    {
        [TestCase(16, ExpectedResult = true)]
        [TestCase(60, ExpectedResult = true)]
        [TestCase(-1, ExpectedResult = false)]
        [TestCase(-10, ExpectedResult = false)]
        public bool GetAge(int fees)
        {
            StudentEnrollment employee = new StudentEnrollment();
           Enrollment e = new Enrollment();
            student s1 = new student();
            e.Fees = fees;
            bool ans = employee.Enrollstudent(s1,e);
            // Assert.That(ans==true);
            return ans;
        }
    }
}

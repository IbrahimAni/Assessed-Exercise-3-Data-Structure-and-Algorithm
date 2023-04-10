using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3_Task_C
{
    internal class Student
    {
        private int id;
        private string name;
        private Boolean enrollmentStatus;

        public Student()
        {
            Id = 0;
            Name = "";
            EnrollmentStatus = true;
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            EnrollmentStatus = true;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Boolean EnrollmentStatus { get { return enrollmentStatus; } set { enrollmentStatus = value; } }
    }
}

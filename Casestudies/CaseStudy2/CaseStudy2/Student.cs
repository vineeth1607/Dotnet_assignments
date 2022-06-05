using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{

    public class Student
    {
        private int student_Id;
        private string student_Name;
        private string dateOfBirth;
        public Student(int Id, string student_Name, string dob)
        {
            this.student_Id = Id;
            this.student_Name = student_Name;
            this.dateOfBirth = dob;
        }
        public int StudentId
        {
            get { return student_Id; }
            set { student_Id = value; }
        }
        public string StudentName
        {
            get { return student_Name; }
            set { student_Name = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }

}
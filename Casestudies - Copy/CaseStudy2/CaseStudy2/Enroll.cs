﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollDate;
        public Student students
        {
            get { return student; }
            set { student = value; }
        }
        public Course courses
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime datetime
        {
            get { return enrollDate; }
            set { enrollDate = value; }
        }
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollDate = enrollmentDate;
        }
    }


}
﻿using System;

namespace SchoolStore.Domain
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class TeacherCourse
    {
        public int TeacherCourseId { get; set; }
        public Teacher Teacher { get; set; }

    }
    
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    public class StudentCourse
    {
        public int StudentCourseId { get; set; }
        public Student Student { get; set; }
    }
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}

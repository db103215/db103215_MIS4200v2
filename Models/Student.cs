using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace db103215_MIS4200v2.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public ICollection<Course> Course { get; set; }
    }

    public class Course
    {

        [Key]
        public int courseID { get; set; }
        public string courseName { get; set; }
        public string description { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }

        public int studentID{ get; set; }
        public virtual Student Student { get; set; }

    }

    public class CourseDetail
    {
        public int courseDetailID { get; set; }
        public int courseID { get; set; }
        public virtual Course Course { get; set; }


    }



}
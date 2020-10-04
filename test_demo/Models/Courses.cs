using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace test_demo.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { set; get; }
        public string CourseName { set; get; }
        public string CourseCode { set; get; }
        public int Fee { set; get; }
        public string ProfessorName { set; get; }
        public string Id { set; get; }
        public ApplicationUser User { set; get; }
    }
}
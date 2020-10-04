using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_demo.Models
{
    public class Car
    {
        public int Id { set; get; }
        [Required]
        [StringLength(3)]
        [Display(Name = "Enter your Car Name")]
        public string CarName { get; set; }
        public string CarMake { set; get; }
    }
}
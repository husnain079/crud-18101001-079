using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Exam_Practice.Models
{
    public class Student
    {
        public string Name { get; set; }
        [Key]
        public string Price { get; set; }
        public string Quantity { get; set; }

        public string message { get; set; }

      

    }
}

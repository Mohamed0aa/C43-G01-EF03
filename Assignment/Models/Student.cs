using Assignment.Models.RelatinalClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public required string Fname { get; set; }
        public required string Lname { get; set; }
        public string? Address { get; set; }

        public required string Age { get; set; }

        public List<StudentsCourses>students { get; set; }

        public Department? department { get; set; }


    }
}

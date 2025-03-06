using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.RelatinalClass
{
    internal class StudentsCourses
    {
        public int StudentID  { get; set; }
        public int CourseID  { get; set; }

        public double? Grade { get; set; }
    }
}

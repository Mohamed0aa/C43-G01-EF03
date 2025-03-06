﻿using Assignment.Models.RelatinalClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<InstructorsCourses> courses { get; set; }

        public List<StudentsCourses>? Student_courses { get; set; }
        public Topic topic { get; set; }



    }
}

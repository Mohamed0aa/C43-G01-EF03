﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Topic
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Course>?courses { get; set; }
    }
}

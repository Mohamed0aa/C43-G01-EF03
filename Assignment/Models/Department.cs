using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Department
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime HiringDate { get; set; }

        public List<Student>students{ get; set; }


        public int ManagerId {  get; set; }
        
        public Instructor Manager { get; set; }
        
        public List<Instructor>instructors{ get; set; }
    }
}

using Assignment.Models.RelatinalClass;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public Decimal Bouns { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public Decimal Salary { get; set; }

        [Required]
        public string Adress { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public Double HourRate { get; set; }
        public List<InstructorsCourses> instructors { get; set; }
        
        public Department?department { get; set; }

        public int workforId {  get; set; }
       
        public Department workfor { get; set; }


    }
}

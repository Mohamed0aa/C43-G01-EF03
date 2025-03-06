using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ConfigClasses
{
    internal class CourseConfigrution : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasColumnType("Varchar(50)");

            builder.Property(c => c.Description).IsRequired().HasColumnType("Varchar(500)");

            builder.Property(c => c.Duration).IsRequired();
        }
    }
}

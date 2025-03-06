using Assignment.Models;
using Assignment.Models.RelatinalClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data
{
    internal class DbContext_ItI: DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent api

            #region classeCreation
            #region DpartmentCreation
            modelBuilder.Entity<Department>().HasKey(D => D.Id);

            modelBuilder.Entity<Department>()
                .Property(D => D.Name).IsRequired()
                .HasColumnType("Varchar(50)");

            modelBuilder.Entity<Department>()
                .Property(D => D.HiringDate).HasColumnType("date")
                .HasDefaultValueSql("getdate()");
            #endregion

            #region ConfgClasses
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion


            #region InstructorsCourses

            modelBuilder.Entity<InstructorsCourses>().HasKey(ic=>new { ic.CourseId, ic.InstructorId });
            #endregion

            #region StudentsCourses

            modelBuilder.Entity<StudentsCourses>().HasKey( ic => new { ic.StudentID, ic.CourseID });
            #endregion


            modelBuilder.Entity<Department>().HasMany(d => d.instructors)
                .WithOne(e => e.workfor)
                .HasForeignKey(e => e.workforId).OnDelete(DeleteBehavior.Restrict); ;
            #endregion


        }

        public DbContext_ItI(): base()
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; DataBase = ITI; Trusted_Connection= True; Encrypt= True; TrustServerCertificate=True");
        }

        public DbSet<Student> Students  { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }



    }
}

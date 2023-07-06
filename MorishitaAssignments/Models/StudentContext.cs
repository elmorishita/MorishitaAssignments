using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MorishitaAssignments.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        { }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Assignments> Assigns { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assignments>().HasData(
                new Assignments
                {
                    AssignmentId = 1,
                    AssignmentName = "Assignment 6.1",
                }
                );

            modelBuilder.Entity<Assignments>().HasData(
               new Assignments
               {
                   AssignmentId = 2,
                   AssignmentName = "Assignment 7.1",
               }
               );

            modelBuilder.Entity<Assignments>().HasData(
              new Assignments
              {
                  AssignmentId = 3,
                  AssignmentName = "Assignment 8.5",
              }
              );

            modelBuilder.Entity<Student>().HasData(
              new Student
              {
                  Id = 1,
                  FirstName = "Sharean",
                  LastName = "Vesey",
                  Grade = "12",
                  StudentAccessLevel = 9
              }
              ); ;

            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 2,
                FirstName = "Dewayne",
                LastName = "Mori",
                Grade = "9",
                StudentAccessLevel = 6
            }
            );

            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 3,
                FirstName = "Esiah",
                LastName = "Lonnell",
                Grade = "9",
                StudentAccessLevel = 6
            }
            );

            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 4,
                FirstName = "Elizabeth",
                LastName = "Shalonda",
                Grade = "8",
                StudentAccessLevel = 2
            }
            );
        }
    }
}

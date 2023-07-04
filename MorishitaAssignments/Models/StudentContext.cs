using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MorishitaAssignments.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        { }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Assignments> Assignments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assignments>().HasData(
                new Assignments
                {
                    AssignmentId = 1,
                    AccessLevel = 1,
                    AssignmentName = "Assignment 6.1",
                }
                );

            modelBuilder.Entity<Assignments>().HasData(
               new Assignments
               {
                   AssignmentId = 2,
                   AccessLevel = 5,
                   AssignmentName = "Assignment 7.1",
               }
               );

            modelBuilder.Entity<Assignments>().HasData(
              new Assignments
              {
                  AssignmentId = 3,
                  AccessLevel = 9,
                  AssignmentName = "Assignment 8.5",
              }
              );
        }
    }
}

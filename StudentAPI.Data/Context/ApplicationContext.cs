using Microsoft.EntityFrameworkCore;
using StudentAPI.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FirstName = "Clinton",
                LastName = "Boamah",
                Email = "clinton.boamah@outlook.com",
                Gender = Gender.Male,
                DateJoined = DateTime.Now,
                DateOfBirth = DateTime.Now,
                Age = 30
            });
        }

        public DbSet<Student> Students { get; set; }
    }
}

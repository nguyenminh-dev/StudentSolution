using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Data
{
    public class StudentDbContextFactory : IDesignTimeDbContextFactory<StudentDbContext>
    {
        public StudentDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-B4G85FN\\SQLEXPRESS;Database=Student;Trusted_Connection=True;");
            return new StudentDbContext(optionsBuilder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Student.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Data
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
    }
}

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Linq;
using System.Text;
using University;


public class UniversityContext : DbContext
{
    public DbSet<Students> Students { get; set; }
    public DbSet<Courses> Courses { get; set; }
    public DbSet<Questions> Questions { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<ExamResult> ExamResults { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-KCI0579;Database=university;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
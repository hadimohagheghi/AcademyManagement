using AcademyManagement.Core.Domain.Student;
using AcademyManagement.Infrastructures.Data.SqlServer.Student;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Common
{
    public class AcademyManagementCommandDbContext : DbContext
    {
        public AcademyManagementCommandDbContext(DbContextOptions<AcademyManagementCommandDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            base.OnModelCreating(modelBuilder);
        }


        DbSet<Core.Domain.Attendance.Attendance> Attendance { get; set; }
        DbSet<Core.Domain.ClassEnrollments.ClassEnrollments> ClassEnrollments { get; set; }
        DbSet<Core.Domain.Classes.Classes> Classes { get; set; }
        DbSet<Core.Domain.Expenses.Expenses> Expenses { get; set; }
        DbSet<Core.Domain.Payments.Payments> Payments { get; set; }
        DbSet<Core.Domain.Students.Students> Students { get; set; }
        DbSet<Core.Domain.TeacherPayments.TeacherPayments> TeacherPayments { get; set; }
        DbSet<Core.Domain.Teachers.Teachers> Teachers { get; set; }
        DbSet<Core.Domain.Tuitions.Tuitions> Tuitions { get; set; }
    }
}

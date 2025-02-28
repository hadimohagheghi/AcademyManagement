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


        DbSet<Core.Domain.Student.Student> Students { get; set; }
    }
}

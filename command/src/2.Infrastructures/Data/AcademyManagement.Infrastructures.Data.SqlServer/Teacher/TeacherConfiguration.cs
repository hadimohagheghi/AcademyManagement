using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Teacher
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Core.Domain.Teachers.Teachers>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Teachers.Teachers> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.DateOfBirth).IsRequired();
            builder.Property(p => p.Gender).IsRequired();
            builder.Property(p => p.PhoneNumber).IsRequired();
            builder.Property(p => p.Specialization).IsRequired();
            builder.Property(p => p.Status).HasDefaultValue(true);
        }
    }
}

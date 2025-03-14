using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Attendance
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Core.Domain.Attendance.Attendances>
    {

        public void Configure(EntityTypeBuilder<Core.Domain.Attendance.Attendances> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Status).HasDefaultValue(true);
        }
    }
}

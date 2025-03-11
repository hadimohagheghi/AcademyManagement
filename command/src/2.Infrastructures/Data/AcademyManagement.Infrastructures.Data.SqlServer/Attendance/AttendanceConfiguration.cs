using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Attendance
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Core.Domain.Attendances.Attendances>
    {

        public void Configure(EntityTypeBuilder<Core.Domain.Attendances.Attendances> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Status).HasDefaultValue(true);
        }
    }
}

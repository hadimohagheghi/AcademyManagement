using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyManagement.Infrastructures.Data.SqlServer.ClassEnrollment
{
    public class ClassEnrollmentConfiguration : IEntityTypeConfiguration<Core.Domain.ClassEnrollments.ClassEnrollments>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.ClassEnrollments.ClassEnrollments> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Status).HasDefaultValue(true);
        }
    }
}

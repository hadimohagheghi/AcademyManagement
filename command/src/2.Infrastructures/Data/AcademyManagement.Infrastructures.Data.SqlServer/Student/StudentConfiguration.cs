using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Student
{
    public class StudentConfiguration : IEntityTypeConfiguration<Core.Domain.Student.Student>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Student.Student> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            
        }
    }
}

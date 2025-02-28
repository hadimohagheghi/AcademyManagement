using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Course
{
    public class CourseConfiguration: 
        IEntityTypeConfiguration<Core.Domain.Course.Course>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Course.Course> builder)
        {
            builder.HasKey(p => p.Id);

            builder

        }
    }
}

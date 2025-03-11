using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Class
{
    public class ClassConfiguration : IEntityTypeConfiguration<Core.Domain.Classes.Classes>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Classes.Classes> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ClassName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Status).HasDefaultValue(true);
        }

    }
}

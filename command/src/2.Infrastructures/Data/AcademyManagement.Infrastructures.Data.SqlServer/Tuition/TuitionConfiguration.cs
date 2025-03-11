using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Tuition
{
    public class TuitionConfiguration : IEntityTypeConfiguration<Core.Domain.Tuitions.Tuitions>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Tuitions.Tuitions> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}

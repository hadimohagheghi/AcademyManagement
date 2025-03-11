using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Infrastructures.Data.SqlServer.TeacherPayment
{
    public class TeacherPaymentConfiguration : IEntityTypeConfiguration<Core.Domain.TeacherPayments.TeacherPayments>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.TeacherPayments.TeacherPayments> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}

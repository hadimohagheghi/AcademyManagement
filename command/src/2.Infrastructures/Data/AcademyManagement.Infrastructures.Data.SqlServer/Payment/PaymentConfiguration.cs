using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Payment
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Core.Domain.Payments.Payments>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Payments.Payments> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}

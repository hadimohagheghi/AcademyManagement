using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Infrastructures.Data.SqlServer.Expense
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Core.Domain.Expenses.Expenses>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Expenses.Expenses> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Category).IsRequired().HasMaxLength(100);
        }
    }
}

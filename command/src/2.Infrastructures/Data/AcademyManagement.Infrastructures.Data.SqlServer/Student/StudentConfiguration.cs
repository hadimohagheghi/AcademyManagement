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
            builder.Property(p => p.Age)
                .HasColumnType("decimal(18,2)");
            builder.Property(c => c.CreateDate)
                .HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.IsActive)
                .HasDefaultValue(true);

            //تنظیمات پایه ای
            //مقادیر محاسباتی
            builder.Property(p => p.Quantity)
                .IsRequired();
            builder.Property(p => p.TotalPrice)
                .HasComputedColumnSql("[Quantity] * [Price]");
            //تولید کننده مقدار
            //Value Generator


            //Concurrency
            //shadow Property
            //...


            //key
            builder.HasOne(c => c.Course)
                .WithMany(s => s.Students)
                .HasForeignKey(p => p.CourseId);
        }
    }
}

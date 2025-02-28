using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.Student
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public decimal Age { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        //
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }


        public string UniqueIdentifier { get; set; }


        //todo
    }
}

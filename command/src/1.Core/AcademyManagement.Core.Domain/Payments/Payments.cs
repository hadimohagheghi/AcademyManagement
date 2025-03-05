using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.Payments
{
    public class Payments
    {
        public Guid Id { get; set; }
        public Guid StudentID { get; set; }
        public Guid ClassID { get; set; }
        public DateTime PaymentDate { get; set; }
        public double PaidAmount { get; set; }
    }
}

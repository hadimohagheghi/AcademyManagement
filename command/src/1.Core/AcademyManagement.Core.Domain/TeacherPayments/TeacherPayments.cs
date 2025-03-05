using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.TeacherPayments
{
    public class TeacherPayments
    {
        public Guid Id { get; set; }
        public Guid TeacherID { get; set; }
        public Guid ClassID { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}

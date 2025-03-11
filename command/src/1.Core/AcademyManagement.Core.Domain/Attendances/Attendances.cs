using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.Attendance
{
    public class Attendances
    {
        public Guid Id { get; set; }
        public Guid StudentID { get; set; }
        public Guid ClassID { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}

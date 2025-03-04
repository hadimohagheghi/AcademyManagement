using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.Attendance
{
    public class Attendance
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid ClassId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}

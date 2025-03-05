using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.ClassEnrollments
{
    public class ClassEnrollments
    {
        public Guid Id { get; set; }
        public Guid StudentID { get; set; }
        public Guid ClassID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool Status { get; set; }
    }
}

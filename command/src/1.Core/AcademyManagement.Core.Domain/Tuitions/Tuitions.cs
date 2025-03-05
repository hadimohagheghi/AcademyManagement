using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.Tuitions
{
    public class Tuitions
    {
        public Guid Id { get; set; }
        public Guid ClassID { get; set; }
        public Guid StudentID { get; set; }
        public string Month { get; set; }
        public double Amount { get; set; }
    }
}

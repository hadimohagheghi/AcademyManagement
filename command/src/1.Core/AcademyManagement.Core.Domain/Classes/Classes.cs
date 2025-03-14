using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyManagement.Core.Domain.Student;

namespace AcademyManagement.Core.Domain.Classes
{
    public class Classes
    {
        public Guid Id { get; set; }
        public Guid TeacherID { get; set; }
        public string ClassName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DaysOfWeek { get; set; }
        public double Fee { get; set; }
        public int MaxStudents { get; set; }
        public bool Status { get; set; }


        public ICollection<Students> Students { get; set; }
    }
}

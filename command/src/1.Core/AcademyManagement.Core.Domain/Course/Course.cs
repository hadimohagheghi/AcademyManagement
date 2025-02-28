using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.Course
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //keys
        public ICollection<Student.Student> Students { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using AcademyManagement.Core.Domain.Student;

namespace AcademyManagement.Core.Domain.Teachers
{
    public class Teachers
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public string Specialization { get; set; }
        public bool Status { get; set; }


        public Guid StudentId { get; set; }
        public Students Students { get; set; }


        //public ICollection<Students> Students { get; set; }

    }

}

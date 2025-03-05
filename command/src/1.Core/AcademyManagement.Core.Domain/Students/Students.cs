using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Core.Domain.Student
{
    public class Students
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ParentName { get; set; }
        public string ParentPhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Status { get; set;}


        //public double Price { get; set; }
        //public int Quantity { get; set; }
        //public double TotalPrice { get; set; }


        //public string UniqueIdentifier { get; set; }
        //key
        //public Guid CourseId { get; set; }
        //public Course.Course Course { get; set; }
    }
}

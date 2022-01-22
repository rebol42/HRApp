using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesApp
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public DateTime BirthDate { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime LayOffDate { get; set; }
        public EmplStatus  EmplStatus { get; set; }
        public string Comments { get; set; }
    }
}

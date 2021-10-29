using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtoAppSecond.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public decimal Basic { get; set; }
        public decimal DA { get; set; }
        public decimal HRA { get; set; }
        public decimal NetSalary { get; set; }
    }
}

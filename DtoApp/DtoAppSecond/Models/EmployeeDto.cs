using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtoAppSecond.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
    }
}

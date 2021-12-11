using DtoAppSecond.Data;
using DtoAppSecond.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtoAppSecond.Controllers
{


    // [Route("api/[controller]")]
    [Route("api/dto")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        private readonly DtoDb _context;
        public EmpsController(DtoDb context)
        {
            _context = context;
        }
        // GET: api/Emps
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeDto>> GetEmps()
        {
            return _context.Employees.Select(e => new EmployeeDto()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DepartmentName = e.DepartmentName
            }).ToList<EmployeeDto>();
        }


    }


   

   

    


}

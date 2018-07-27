using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsApp.Shared.Models;

namespace StudentsApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/Student
        [HttpGet]
        [Route("Students")]
        public IEnumerable<Student> Get()
        {
            return new List<Student>{ new Student {Name = "Siarhei", Age = 23, Faculty = "Computer tecnology" }};
        }
    }
}

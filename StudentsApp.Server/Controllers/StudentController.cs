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
        private readonly List<Student> students;

        public StudentController()
        {
            students = new List<Student>
            {
                new Student {Id = 1, Name = "Siarhei", Age = 23, Faculty = "Computer tecnology" },
                new Student {Id = 2, Name = "Pavel", Age = 25, Faculty = "Computer tecnology" },
                new Student {Id = 3 ,Name = "Elena", Age = 23, Faculty = "Computer tecnology" }
            };
        }

        // GET: api/Students
        [HttpGet]
        [Route("Students")]
        public IEnumerable<Student> Get()
        {
            return students.ToList();
        }

        // GET: api/Student/{id}
        [HttpGet("{id}")]
        [Route("Students")]
        public Student GetStudent(int id)
        {
            return students.First(s => s.Id == id);
        }
    }
}

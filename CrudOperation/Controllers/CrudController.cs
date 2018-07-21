using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Neudesic.CrudOperation.Model;

namespace Neudesic.CrudOperation.Controllers
{
    [Route("api/[controller]")]
    public class CrudController : Controller
    {
        public List<StudentModel> Student = new List<StudentModel>()
        {
            new StudentModel()
            {
                Id=1,
                Name="Dhanusha",
                Age=20
            },
            new StudentModel()
            {
                Id=2,
                Name="Ramya",
                Age=21
            }
        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Student);
        }
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var student = Student.FirstOrDefault(e => e.Id == id);
            if (student != null)
                return Ok(student);
            else
                return NotFound();
        }
        // POST: api/Employoees
        [HttpPost]
        public IActionResult Post(StudentModel student)
        {
            Student.Add(student);
            return Ok(Student);
        }
        // PUT: api/Employoees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
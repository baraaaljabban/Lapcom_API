using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lapcom_API.Models;

namespace Lapcom_API.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            using (var context =  new LapcomContext())
            {
                return context.Student.ToList();
            }
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            using (var context = new LapcomContext())
            {
                Student item = context.Student.Find(id);
                if(item == null)
                {
                    return null;
                }
                return item;
            }
        }

        // POST: api/Student
        [HttpPost]
        public void Post([FromBody]Student value)
       {
            using (var context = new LapcomContext())
            {
                context.Student.Add(value);
                context.SaveChanges();
            }
        }
        
        // PUT: api/Student/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Student value)
        {
            using (var context = new LapcomContext())
            {
                var todo = context.Student.Find(id);
                if (todo == null)
                {
                    return NotFound();
                }
                context.Student.Update(todo);
                context.SaveChanges();
                return NoContent();
            }
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (var context = new LapcomContext())
            {
                var Student = context.Student.Find(id);
                if (Student == null)
                {
                    return NotFound();
                }

                context.Student.Remove(Student);
                context.SaveChanges();
                return NoContent();
            }
        }
    }
}

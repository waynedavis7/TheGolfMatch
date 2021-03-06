using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMatch.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheMatch.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(TheMatch.Domain.ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<TheMatch.Domain.Course> Get()
        {
            return _courseRepository.GetCourses();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public TheMatch.Domain.Course Get(int id)
        {
            return _courseRepository.GetCourse(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] TheMatch.Domain.Course course)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

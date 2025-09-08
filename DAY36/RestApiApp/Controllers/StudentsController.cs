using Microsoft.AspNetCore.Mvc;
using RestApiApp.Data;
using RestApiApp.Models;

namespace RestApiApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  // Base route: api/students
    public class StudentsController : ControllerBase
    {
        [HttpGet]  // GET api/students
        public IActionResult GetAllStudents()
        {
            return Ok(FakeRepository.Students);
        }

        [HttpGet("{id}")]  // GET api/students/1
        public IActionResult GetStudentById(int id)
        {
            var student = FakeRepository.Students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpGet("{id}/courses")]  // GET api/students/1/courses
        public IActionResult GetStudentCourses(int id)
        {
            var student = FakeRepository.Students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return Ok(student.Courses);
        }

        [HttpPost]  // POST api/students
        public IActionResult AddStudent([FromBody] Student student)
        {
            student.Id = FakeRepository.Students.Max(s => s.Id) + 1;
            FakeRepository.Students.Add(student);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }
    }
}

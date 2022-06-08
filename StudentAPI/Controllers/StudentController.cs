using Microsoft.AspNetCore.Mvc;
using StudentAPI.Logic.IRepository;
using StudentAPI.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            return Ok(await _studentRepository.GetAllStudents());
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            return Ok(await _studentRepository.GetStudent(id));
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student) 
        {
            var result = await _studentRepository.AddStudent(student);
            if (result != null)
            {
                return Ok(result);
            }

            return null;
        }

        // PUT api/<StudentController>/5
        [HttpPut]
        public async Task<IActionResult> UpdateStudent([FromBody] Student student) 
        {
            var result = await _studentRepository.UpdateStudent(student);
            return Ok(result);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id) 
        {
           return Ok(await _studentRepository.DeleteStudent(id));            
        }
    }
}

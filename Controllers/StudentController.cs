using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Web_Api_CRUD_Dotnet_Core_8.Model;

namespace Web_Api_CRUD_Dotnet_Core_8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var stds = await _context.Students.ToListAsync();
            return Ok(stds);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            var std = await _context.Students.FindAsync(id);
            if(std is null)
            {
                return NotFound();
            }

            return Ok(std);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> Create(Student std)
        {
            await _context.Students.AddAsync(std);
            await _context.SaveChangesAsync();
            return Ok(std);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var std = await _context.Students.FindAsync(id);

            if(std is null)
            {
                return NotFound();
            }

            _context.Students.Remove(std);
            await _context.SaveChangesAsync();

            return Ok(std);
        }
    }
}

using AngularAuthAPI.Models;
using AngularAuthAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task = AngularAuthAPI.Models.Task;

namespace AngularAuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertController : ControllerBase

    {
        private readonly AppDbContext _authContext;
        public InsertController(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }

        [HttpPost("insertData")]
        //public async Task<IActionResult> Authenticate([FromBody] Users userObj)
        //public IActionResult InsertData([FromBody] Task taskObj)
        public async Task<IActionResult> InsertData([FromBody] Task taskObj)
        {
            if (taskObj == null)
                return BadRequest();
            //userObj.Password = PasswordHasher.HashPassword(taskObj.Password);     //these will help to hash the password.
            // taskObj.Id = taskObj.Task_Id;
            // userObj.Token = "";

            if (taskObj.Title == null)
                return NotFound(new { Message = "Title Not Found!" });

            if (taskObj.Creation_date == null)
                return NotFound(new { Message = "Creation Date Not Found!" });

            if (taskObj.Due_date == null)
                return NotFound(new { Message = "Due Date Not Found!" });

            if (taskObj.Status == null)
                return NotFound(new { Message = "Status Not Found!" });

            if (taskObj.Priority == null)
                return NotFound(new { Message = "Priority Not Found!" });

            if (taskObj.Description == null)
                return NotFound(new { Message = "Description Not Found!" });
          
            await _authContext.Tasks.AddAsync(taskObj); //these line will help to send data in database
            await _authContext.SaveChangesAsync();
            return Ok(new
            {
                Message = "To-Do List Created Sussessfully!."
            });
        }

        //using these user can only login when it with has token men
        //[Authorize]
        //ctreate a API to get all users
        [HttpGet]
        public async Task<ActionResult<Task>> GetAllTasks()
        {
            return Ok(await _authContext.Tasks.ToListAsync());
        }
    }
}

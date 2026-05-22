using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")] //localhost:5001/api/users (UsersController -> users)
    [ApiController]

    public class UsersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetUsers()
        {
            var members = await context.Users.ToListAsync();

            return members;
        }

        [HttpGet("{id}")] //localhost:5001/api/randy-id
        public async Task<ActionResult<AppUser>> GetUser (string id)
        {
            var member = await context.Users.FindAsync(id);

           if (member == null) return NotFound();

           return member;
        }
    }
}
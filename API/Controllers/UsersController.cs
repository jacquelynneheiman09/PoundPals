using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class UsersController : BaseAPIController
    {
        public readonly DataContext context;

        public UsersController(DataContext context)
        {
            this.context = context;    
        }

        [HttpGet]   //api/users
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            return await context.Users.FindAsync(id);
        }
    }
}
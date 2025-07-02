using LeoShop.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace LeoShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserManagementController : ControllerBase
    {
        private readonly LeoShopDbContext _context;
        private readonly IUserService _userService;
        public UserManagementController(LeoShopDbContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            return await _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await _userService.GetUserById(id);
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            return await _userService.CreateUser(user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id, User user)
        {
            return await _userService.UpdateUser(id, user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUser(id);
            return NoContent();
        }
    }
}

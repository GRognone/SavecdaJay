using ApiUser.Db;
using ApiUser.Extensions;
using ApiUser.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly UserDbContext _context;


        public PasswordController()
        {
            _context = new UserDbContext();
        }

        [HttpPut]
        public async Task <ActionResult> ChangePassword(UserChangePasswordViewModel jSonUser)
            {
            User? user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == jSonUser.UserName);

            if (user != null && user.Password.CheckPassword(jSonUser.Password))
            {
                user.Password = jSonUser.NewPassword.ToPassword();
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
    }
}

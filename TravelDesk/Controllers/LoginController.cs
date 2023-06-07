using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Policy;
using System.Text;
using TravelDesk.Context;
using TravelDesk.Models;
using TravelDesk.ViewModels;

namespace TravelDesk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        TravelDeskDbContext _context;
        IConfiguration _config;



        public LoginController(TravelDeskDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;



        }



        [HttpPost]
        public IActionResult Login(LoginViewModel user)
        {
            IActionResult response = Unauthorized();
            var obj = Authenticate(user);
            if (obj != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }
            return response;
        }



        private string GenerateJSONWebToken(LoginViewModel user)
        {
            var securityKey = new
            SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey,
            SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
           _config["Jwt:Issuer"],
           null,
           expires: DateTime.Now.AddMinutes(120),
           signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }




        private User Authenticate(LoginViewModel user)
        {
            User obj = _context.Users.FirstOrDefault(x => x.Email == user.Email
&& x.Password == user.Password);
            return obj;
        }

        
    }
}

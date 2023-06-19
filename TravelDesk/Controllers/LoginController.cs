using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TravelDesk.Context;
using TravelDesk.ViewModels;
using TravelDeskNst.Models;

namespace TravelDesk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        TravelDeskDbContext _context;
        IConfiguration _configuration;

        //public ClaimsIdentity? FirstName { get; private set; }

        public LoginController(TravelDeskDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel user)
        {
            IActionResult response = Unauthorized();
            var obj = Authenticate(user);

            CommonTypeRef c = _context.CommonTypes.Where(x => x.Id == obj.RoleId).FirstOrDefault();
            user.RoleName = c.Value;



            if (obj != null)
            {
                var tokenString = GenerateJSONWebToken(obj.Id, user.Email, user.RoleName);
                response = Ok(new { token = tokenString });
            }
            return response;
        }
        private string GenerateJSONWebToken(int id, string email, string roleName)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("Id", id.ToString()));
            claims.Add(new Claim("Email", email));
            claims.Add(new Claim("Role", roleName.ToString()));
            // claims.Add(new Claim("FirstName", FirstName));


            //   Claim[] claims = new[]
            //{
            //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            //        new Claim(JwtRegisteredClaimNames.Sid, id.ToString()),
            //        new Claim(JwtRegisteredClaimNames.Email, email),
            //        new Claim(ClaimTypes.Role, roleName.ToString()),
            //        new Claim(type:"Date", DateTime.Now.ToString())
            //   };
            var securityKey = new
                 SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));



            //var securityKey = new SymmetricSecurityKey(_configuration["Jwt:key"]);



            var credentials = new SigningCredentials(securityKey,
            SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
           _configuration["Jwt:Issuer"],
            claims,
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

//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.IdentityModel.Tokens;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using TravelDesk.Context;
//using TravelDesk.ViewModels;
//using TravelDeskNst.Models;

//namespace TravelDesk.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class LoginController : ControllerBase
//    {
//        TravelDeskDbContext _context;
//        IConfiguration _config;
//        public LoginController(TravelDeskDbContext context, IConfiguration config)
//        {
//            _context = context;
//            _config = config;
//        }
//        [HttpPost]
//        public IActionResult Login(LoginViewModel user)
//        {
//            IActionResult response = Unauthorized();
//            var obj = Authenticate(user);
//            if (obj != null)
//            {
//                CommonTypeRef c= _context.CommonTypes.Where(x=x>.id)
//                var tokenString =
//                    GenerateJSONWebToken(user.FirstName, user.Email, user.Role);
//                response = Ok(new { token = tokenString });
//            }
//            return response;
//        }
//        private string GenerateJSONWebToken(int Id, string password, int role)
//        {
//            Claim[] claims = new[]
//         {
//                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
//                 new Claim(JwtRegisteredClaimNames.Sid, Id.ToString()),
//                 new Claim(JwtRegisteredClaimNames.Email, password),
//                 new Claim(ClaimTypes.Role, role.ToString()),
//                 new Claim(type:"Date", DateTime.Now.ToString())
//            };
//            var securityKey = new
//            SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

//            var credentials = new SigningCredentials(securityKey,
//            SecurityAlgorithms.HmacSha256);
//            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
//           _config["Jwt:Issuer"],
//            claims,
//expires: DateTime.Now.AddMinutes(120),
//signingCredentials: credentials);
//            return new JwtSecurityTokenHandler().WriteToken(token);
//        }

//        public User Authenticate(User user)
//        {
//            User obj = _context.Users.FirstOrDefault(x => x.Email == user.Email
//            && x.Password == user.Password);
//            if(obj!=null)
//            {
//                var temp = (from x in obj
//                            join y in _context.CommonTypes on x
//                            equals y.Id
//                            select new
//                            {
//                                Role = y.Type
//                            });

//            }

//            return obj;
//        }
//    }

//}

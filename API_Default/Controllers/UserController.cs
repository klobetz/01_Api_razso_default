using Api_teszt.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Versioning;

namespace API_Default.Controllers
{
    [Route("api/teszt/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUser()
        {
            var usersList = new List<User>
            {
                new User
                {
                    Id = 1,
                    FName = "Klobetz",
                    LName = "Ákos",
                    Email= "klobetz@gmail.com",
                    Password = "Passwod",
                },
                new User
                {
                    Id = 2,
                    FName = "Teszt",
                    LName = "Elek",
                    Email= "Teszt@gmail.com",
                    Password = "Passwod",
                }
            };
            return Ok(usersList);
        }
    }
}

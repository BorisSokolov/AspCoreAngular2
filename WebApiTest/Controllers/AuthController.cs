using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Data;
using WebApiTest.Dtos;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserRegisterDro userRegisterDro)
        {
            userRegisterDro.UserName = userRegisterDro.UserName.ToLower();

            if (await _authRepository.UserExists(userRegisterDro.UserName))
            {
                return BadRequest("Username already exists");
            }

            var newUser = new User
            {
                UserName = userRegisterDro.UserName
            };

            var createdUser = await _authRepository.Register(newUser, userRegisterDro.Password);

            return StatusCode(201);
        }
    }
}
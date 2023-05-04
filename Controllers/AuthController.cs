using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_api.DTOs.User;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;   
        }


        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDTO request) {
            var response = await _authRepo.Register(
                new User {Username = request.Username}, request.Password
            );

            if (!response.Success) {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDTO request) {
            var response = await _authRepo.Login(request.Username, request.Password);

            if (!response.Success) {
                return BadRequest(response);
            }
            return Ok(response);
        }


    }
}
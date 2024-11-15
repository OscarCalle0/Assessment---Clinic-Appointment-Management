using Appointment_Management.Models;
using Appointment_Management.Services;
using Appointment_Management.Config;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Appointment_Management.DTOs.Requests;
using Appointment_Management.DTOs.Response;
using Appointment_Management.Repositories;

namespace Appointment_Management.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto loginDto)
        {
            if (loginDto == null || string.IsNullOrEmpty(loginDto.Email) || string.IsNullOrEmpty(loginDto.Password))
            {
                return BadRequest("Email and password are required.");
            }

            try
            {
                var user = await _userService.Authenticate(loginDto.Email, loginDto.Password);

                if (user == null)
                {
                    return Unauthorized("Invalid email or password.");
                }

                var token = JWT.GenerateJwtToken(user);  // Generate JWT token

                return Ok(new { Token = token });  // Return token in response
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");  // Handle unexpected errors
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto registerDto)
        {
            if (registerDto == null || string.IsNullOrEmpty(registerDto.Email) || string.IsNullOrEmpty(registerDto.Password))
            {
                return BadRequest("Email and password are required.");
            }

            try
            {
                var existingUser = await _userService.GetByEmail(registerDto.Email);
                if (existingUser != null)
                {
                    return Conflict("Email is already in use.");
                }

                var newUser = new User { Email = registerDto.Email, RoleId = registerDto.RoleId };
                await _userService.Register(newUser, registerDto.Password);

                return Ok(new { Message = "User registered successfully." });  // Success message
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");  // Handle unexpected errors
            }
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPasswordDto)
        {
            if (forgotPasswordDto == null || string.IsNullOrEmpty(forgotPasswordDto.Email))
            {
                return BadRequest("Email is required.");
            }

            try
            {
                var user = await _userService.GetByEmail(forgotPasswordDto.Email);
                if (user == null)
                {
                    return NotFound("User not found.");
                }

                var token = JWT.GeneratePasswordResetToken(user);  // Generate password reset token

                Console.WriteLine($"Password reset token for {user.Email}: {token}");

                return Ok(new { Message = "Password reset email sent." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto resetPasswordDto)
        {
            if (resetPasswordDto == null || string.IsNullOrEmpty(resetPasswordDto.Token) || string.IsNullOrEmpty(resetPasswordDto.NewPassword))
            {
                return BadRequest("Token and new password are required.");
            }

            try
            {
                // Token validation and password reset should be implemented here.
                
                return Ok(new { Message = "Password reset successful." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

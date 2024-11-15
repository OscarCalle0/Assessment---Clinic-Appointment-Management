using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Appointment_Management.Models;

namespace Appointment_Management.Config
{
    public static class JWT
    {
        private static string _secretKey;
        private static string _issuer;
        private static string _audience;
        private static int _expiresIn;

        static JWT()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            _secretKey = configuration["JwtSettings:JwtKey"];
            _issuer = configuration["JwtSettings:JwtIssuer"];
            _audience = configuration["JwtSettings:JwtAudience"];
            _expiresIn = int.Parse(configuration["JwtSettings:JwtExpiresIn"]);
        }

        public static string GenerateJwtToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: null,  // Additional claims can be added
                expires: DateTime.Now.AddMinutes(_expiresIn),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static string GeneratePasswordResetToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: null,  // Claims for user identification can be added
                expires: DateTime.Now.AddMinutes(5),  // Expiration time set for 5 minutes
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

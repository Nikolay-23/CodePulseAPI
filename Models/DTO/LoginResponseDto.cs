﻿namespace CodePulseAPI.Models.DTO
{
    public class LoginResponseDto
    {
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
        public List<string> Roles { get; set; } = null!;

    }
}

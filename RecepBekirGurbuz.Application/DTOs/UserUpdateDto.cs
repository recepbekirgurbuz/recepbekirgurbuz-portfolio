﻿namespace RecepBekirGurbuz.Application.DTOs
{
    public class UserUpdateDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace SupportService.Domain
{
    public class User
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public int Rating = 0;
    }
}
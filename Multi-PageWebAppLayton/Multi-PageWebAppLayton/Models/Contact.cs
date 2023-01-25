﻿using System.ComponentModel.DataAnnotations;
namespace Multi_PageWebAppLayton.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }
    }
}
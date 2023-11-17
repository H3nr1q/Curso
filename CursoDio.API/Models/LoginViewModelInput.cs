﻿using System.ComponentModel.DataAnnotations;

namespace CursoDio.API.Models
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O login é obrigatório")]
        public string login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string password { get; set; }
    }
}
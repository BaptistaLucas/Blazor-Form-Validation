using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace blazormovie.Shared
{
    public class Cadastro
    {
        [Required]
        public string Titulo {get; set;}
        [Required]
        public string Nome {get; set;}
        [Required]
        public string Sobrenome  {get; set;}
        [Required]
        public DateTime? DataDeNascimento { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]  
        public string Senha { get; set; }
        [Required]
        [Compare("Senha",  ErrorMessage = "Senha não é igual, favor verificar")]
        public string ConfirmarSenha { get; set; }
        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Aceitar os termos é obrigatório")]
        public bool Termos { get; set; }


    }
}
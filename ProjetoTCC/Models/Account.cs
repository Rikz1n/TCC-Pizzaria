using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class LoginViewModel
    {
        // Display para definir o texto apresentado ao usuario, prompt é o placeholder
        // Required define a propriedade como obrigatória
        // EmailAddress define a propriedade como endereço de email
        // StringLength define o tamanho máximo e minimo de um texto
        [Display(Name = "E-mail de Acesso", Prompt = "{0}")]
        [Required(ErrorMessage = "Por favor, informe seu E-mail de Acesso")]
        [EmailAddress(ErrorMessage = "Por favor, informe um E-mail válido")]
        [StringLength(100, ErrorMessage = "Seu E-mail de acesso não pode possuir mais de 100 caracteres")]
        public string Email { get; set; }

        [Display(Name = "Senha", Prompt = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Por favor, informe sua Senha")]
        [StringLength(20, ErrorMessage = "Sua Senha não pode possuir mais de 20 caracteres")]
        public string Senha { get; set; }

        public bool ManterConectado { get; set; }
    }
}

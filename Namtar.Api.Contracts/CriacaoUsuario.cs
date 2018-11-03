using System;
using System.ComponentModel.DataAnnotations;

namespace Namtar.Api.Contracts
{
    public class CriacaoUsuario
    {
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }

        public string ConfirmacaoSenha { get; set; }
    }
}

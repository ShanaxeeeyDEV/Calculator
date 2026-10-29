using System.ComponentModel.DataAnnotations;

namespace Calculator.Models.Auth
{
    public class SignModel
    {

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirme a senha")]
        [Compare(nameof(Password), ErrorMessage = "As senhas não coincidem")]
        public string ConfirmPassword { get; set; }

    }
}

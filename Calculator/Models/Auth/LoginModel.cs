using System.ComponentModel.DataAnnotations;

namespace Calculator.Models.Auth
{
    public class LoginModel
    {

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
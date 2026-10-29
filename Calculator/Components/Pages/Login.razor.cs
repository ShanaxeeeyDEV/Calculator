using Calculator.Models.Auth;
using Calculator.Services;
using Microsoft.AspNetCore.Components;

namespace Calculator.Components.Pages
{
    public partial class Login
    {
        [Inject] private AuthService _authService { get; set; } = default;
        [Inject] private NavigationManager _navManager { get; set; } = default;

        private LoginModel _login = new();
        private string? _output;

        private async Task LoginHandler()
        {
            _output = null;

            bool validLogin = await _authService.isValid(_login.Email, _login.Password);

            if (validLogin)
                _navManager.NavigateTo("/home");
            else
                _output = "E-mail ou senha inválidos.";
        }
    }
}
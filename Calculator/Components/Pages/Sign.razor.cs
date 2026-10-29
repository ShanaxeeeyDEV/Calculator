using Calculator.Data;
using Calculator.Models.Auth;
using Calculator.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Components.Pages
{
    public partial class Sign
    {
        [Inject] private AuthService _authService { get; set; } = default;
        [Inject] private AppDbContext _context { get; set; } = default;
        [Inject] private NavigationManager _navManager { get; set; } = default;

        private SignModel _sign = new();
        private string? _output;

        private async Task SignHandler()
        {
            _output = null;

            if (await _authService.existsUser(_sign.Email))
            {
                _output = "Esta conta já existe";
                return;
            }

            User user = new User()
            {
                Email = _sign.Email,
                Password = _sign.Password
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            _navManager.NavigateTo("/login");
        }
    }
}
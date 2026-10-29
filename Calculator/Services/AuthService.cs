using Calculator.Data;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Services
{
    public class AuthService
    {

        private readonly AppDbContext _dbContext;

        public AuthService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> isValid(string email, string password)
        {
            var user = await _dbContext.Users
                .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

            return user != null;
        }

        public async Task<bool> existsUser(string email)
        {
            var response = await _dbContext.Users.
                FirstOrDefaultAsync(u => u.Email == email);

            return response != null;
        }
    }
}
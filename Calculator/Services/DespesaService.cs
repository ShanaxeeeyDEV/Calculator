using Calculator.Data;

namespace Calculator.Services
{
    public class DespesaService
    {

        private AppDbContext _dbContext;

        public DespesaService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private async Task LoadDataAsync()
        {

        }
    }
}
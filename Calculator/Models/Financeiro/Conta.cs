namespace Calculator.Models.Financeiro
{
    public class Conta
    {

        public int Id { get; set; }
        public decimal Saldo { get; set; }
        public ICollection<Despesa> Despesas { get; set; } = new List<Despesa>();
        public ICollection<Investimento> Investimentos { get; set; } = new List<Investimento>();
    }
}

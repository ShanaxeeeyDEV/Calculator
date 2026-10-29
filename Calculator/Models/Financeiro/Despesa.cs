using Calculator.Models.Auth;

namespace Calculator.Models.Financeiro
{
    public class Despesa
    {

        public Conta Conta { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

    }
}

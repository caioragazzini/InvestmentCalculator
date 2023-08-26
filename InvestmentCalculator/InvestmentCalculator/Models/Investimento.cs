using System.ComponentModel.DataAnnotations;

namespace InvestmentCalculator.Models
{
    public class Investimento
    {       
        public decimal ValorInicial { get; set; }
        public int PrazoMeses { get; set; }        
    }
}

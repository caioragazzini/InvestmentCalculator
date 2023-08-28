namespace InvestmentCalculator.Models
{
    public class InvestimentoResultado
    {
        private decimal _valorBruto;
        private decimal _valorLiquido;

        public decimal ValorBruto
        {
            get => _valorBruto;
            set => _valorBruto = decimal.Round(value, 3); 
        }

        public decimal ValorLiquido
        {
            get => _valorLiquido;
            set => _valorLiquido = decimal.Round(value, 3); 
        }
    }
}

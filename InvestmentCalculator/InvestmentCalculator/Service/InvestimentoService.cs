using InvestmentCalculator.Models;

namespace InvestmentCalculator.Service
{
    public class InvestimentoService : IInvestimentoService
    {
        public InvestimentoResultado CalcularInvestimento(Investimento investimento)
        {
            decimal CDI = 0.009m; // 0,9%
            decimal TB = 1.08m; // 108%

            decimal valorBruto = investimento.ValorInicial;
            decimal valorLiquido = investimento.ValorInicial;

            for (int mes = 0; mes < investimento.PrazoMeses; mes++)
            {
                decimal rendimentoMensal = valorBruto * CDI * TB;
                valorBruto += rendimentoMensal;
                valorLiquido += rendimentoMensal - CalcularImposto(rendimentoMensal, mes);
            }

            return new InvestimentoResultado
            {
                ValorBruto = valorBruto,
                ValorLiquido = valorLiquido
            };
        }

        private decimal CalcularImposto(decimal rendimento, int mes)
        {
            decimal[] faixas = { 0.225m, 0.2m, 0.175m, 0.15m };
            if (mes < 6) return rendimento * faixas[0];
            if (mes < 12) return rendimento * faixas[1];
            if (mes < 24) return rendimento * faixas[2];
            return rendimento * faixas[3];
        }
    }
}

using InvestmentCalculator.Models;

namespace InvestmentCalculator.Service
{
    public interface IInvestimentoService
    {
        InvestimentoResultado CalcularInvestimento(Investimento investimento);
    }
}

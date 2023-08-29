namespace InvestmentCalculator.Infrastructure
{
    public class ConstantesInvestimento : IConstantesInvestimento
    {
        public decimal CDI { get; } = 0.009m;
        public decimal TB { get; } = 1.08m;

    }
}

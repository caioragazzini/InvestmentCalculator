using InvestmentCalculator.Infrastructure;
using InvestmentCalculator.Models;
using InvestmentCalculator.Service;
using Moq;
using Xunit;

namespace InvestmentCalculator.Tests
{
    public class InvestimentoServiceTests
    {
        [Fact]
        public void TestCalcularInvestimento()
        {            
            // Arrange
            var constantesMock = new Mock<IConstantesInvestimento>();
            constantesMock.SetupGet(c => c.CDI).Returns(0.009m);
            constantesMock.SetupGet(c => c.TB).Returns(1.08m);

            var investimentoService = new InvestimentoService(constantesMock.Object);

            var investimento = new Investimento
            {
                ValorInicial = 1000m,
                PrazoMeses = 12
            };

            // Act
            var resultado = investimentoService.CalcularInvestimento(investimento);

            // Assert
            Assert.NotNull(resultado);
            
        }

       
    }
}

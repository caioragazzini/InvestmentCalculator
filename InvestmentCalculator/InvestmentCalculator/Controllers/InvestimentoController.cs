using InvestmentCalculator.Models;
using InvestmentCalculator.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvestmentCalculator.Controllers
{
    [ApiController]
    [Route("api/investimentos")]
    public class InvestimentoController : ControllerBase
    {
        private readonly IInvestimentoService _investimentoService;

        public InvestimentoController(IInvestimentoService investimentoService)
        {
            _investimentoService = investimentoService;
        }

        [HttpPost("calcular")]
        public ActionResult CalcularInvestimento([FromBody]Investimento investimento)
        {
            try
            {
                if (investimento.ValorInicial <= 0 || investimento.PrazoMeses <= 1)
                {
                    return BadRequest("Valor inicial deve ser positivo e prazo deve ser maior que 1 mês.");
                }

                InvestimentoResultado resultado = _investimentoService.CalcularInvestimento(investimento);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro durante o cálculo: {ex.Message}");
            }
        }
    }
}
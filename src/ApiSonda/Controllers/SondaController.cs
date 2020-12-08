using Microsoft.AspNetCore.Mvc;
using Sonda.Servicos;

namespace ApiSonda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SondaController : ControllerBase
    {
        [HttpGet]
        [Route("/movimentar")]
        public IActionResult MovimentarSonda([FromServices] ISondaServicos sondaServicos, string tamanhoQuadrante, 
            string posicaoAtualSonda1, string sequenciaMovimentoSonda1, string posicaoAtualSonda2, string sequenciaMovimentoSonda2)
        {
            string proximaPosicaoSonda1 = sondaServicos.MonvimentaSonda(tamanhoQuadrante, posicaoAtualSonda1, sequenciaMovimentoSonda1);
            string proximaPosicaoSonda2 = sondaServicos.MonvimentaSonda(tamanhoQuadrante, posicaoAtualSonda2, sequenciaMovimentoSonda2);

            return Ok(new { proximaPosicaoSonda1 = proximaPosicaoSonda1, proximaPosicaoSonda2 = proximaPosicaoSonda2 });
        }
    }
}

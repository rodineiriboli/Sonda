using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sonda.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSonda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SondaController : ControllerBase
    {
        [HttpGet]
        [Route("/movimentar")]
        public IActionResult MovimentarSonda([FromServices] ISondaServicos sondaServicos, string posicaoAtual, string direcaoDoMovimento)
        {

            string posicaoCardinal = sondaServicos.DefineAlinhamentoCardinal(posicaoAtual, direcaoDoMovimento);

            return Ok(new { posicaoCardinal = sondaServicos.DefineAlinhamentoCardinal(posicaoAtual, direcaoDoMovimento) });
        }
    }
}

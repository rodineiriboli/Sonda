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
        public IActionResult MovimentarSonda([FromServices] ISondaServicos sondaServicos, string tamanhoQuadrante, string posicaoAtual, string sequenciaMovimento)
        {
            string posicaoSonda1 = "1 3 N";//sondaServicos.MonvimentaSonda(tamanhoQuadrante, posicaoAtual, sequenciaMovimento);

            return Ok(new { posicaoSonda1 = posicaoSonda1, posicaoSonda2 = posicaoSonda1 });
        }
    }
}

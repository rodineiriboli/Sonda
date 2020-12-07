using System;
using System.Collections.Generic;
using System.Text;

namespace Sonda.Servicos
{
    public interface ISondaServicos
    {
        string DefineAlinhamentoCardinal(string posicaoAtual, string direcaoDoMovimento);
        string MonvimentaSonda(string tamanhoQuadrante, string posicaoAtual, string sequenciaMovimento);
    }
}
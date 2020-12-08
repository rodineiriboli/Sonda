using System;

namespace Sonda.Servicos
{
    public class SondaServicos : ISondaServicos
    {
        public string DefineAlinhamentoCardinal(string posicaoAtual, string direcaoDoMovimento)
        {
            posicaoAtual = posicaoAtual.ToUpper();
            direcaoDoMovimento = direcaoDoMovimento.ToUpper();

            if (posicaoAtual != "N" && posicaoAtual != "E" && posicaoAtual != "S" && posicaoAtual != "W"
                && (direcaoDoMovimento != "L" && direcaoDoMovimento != "R"))
            {
                return "Os pontos cardinais só podem ser N, E, S ou W";
            }
            return new Dominio.SondaDominio().DefineAlinhamentoCardinal(posicaoAtual, direcaoDoMovimento);
        }
        
        public string MonvimentaSonda(string tamanhoQuadrante, string posicaoAtual, string sequenciaMovimento)
        {
            int quantidadeDeMovimentos = sequenciaMovimento.Length;

            for (int i = 0; i < quantidadeDeMovimentos; i++)
            {
                if (sequenciaMovimento.Substring(i, 1) != "M")
                {
                    string novaDirecaoSonda = DefineAlinhamentoCardinal(posicaoAtual.Substring(4, 1), sequenciaMovimento.Substring(i, 1));
                    posicaoAtual = string.Concat(posicaoAtual.Remove(4, 1), novaDirecaoSonda);
                }
                else
                {
                    posicaoAtual = DefinePosicao(posicaoAtual);
                }
            }
            return posicaoAtual;
        }

        private string DefinePosicao(string posicaoAtual)
        {
            string direcao = posicaoAtual.Substring(4, 1);
            int x = Convert.ToInt32(posicaoAtual.Substring(0, 1));
            int y = Convert.ToInt32(posicaoAtual.Substring(2, 1));

            switch (direcao)
            {
                case "N": //move eixo Y
                    y++;
                    posicaoAtual = posicaoAtual.Substring(0, 2) + Convert.ToString(y) + posicaoAtual[3..];
                    break;
                case "S": //move eixo Y
                    y--;
                    posicaoAtual = posicaoAtual.Substring(0,2) + Convert.ToString(y) + posicaoAtual[3..];
                    break;
                case "E": //move eixo X
                    x++;
                    posicaoAtual = Convert.ToString(x) + posicaoAtual[1..];
                    break;
                case "W": //move eixo X
                    x--;
                    posicaoAtual = Convert.ToString(x) + posicaoAtual[1..];
                    break;
            }
            return posicaoAtual;
        }
    }
}
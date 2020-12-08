namespace Sonda.Dominio
{
    public class SondaDominio
    {
        public string AlinhamentoCardinal { get; set; }

        public string DefineAlinhamentoCardinal(string posicaoAtual, string direcaoDoMovimento)
        {
            posicaoAtual = posicaoAtual.ToUpper();
            direcaoDoMovimento = direcaoDoMovimento.ToUpper();

            switch (posicaoAtual)
            {
                case "N":
                    if (direcaoDoMovimento == "R")
                        AlinhamentoCardinal = "E";
                    else AlinhamentoCardinal = "W";
                    break;

                case "E":
                    if (direcaoDoMovimento == "R")
                        AlinhamentoCardinal = "S";
                    else AlinhamentoCardinal = "N";
                    break;

                case "S":
                    if (direcaoDoMovimento == "R")
                        AlinhamentoCardinal = "W";
                    else AlinhamentoCardinal = "E";
                    break;

                case "W":
                    if (direcaoDoMovimento == "R")
                        AlinhamentoCardinal = "N";
                    else AlinhamentoCardinal = "S";
                    break;
            }
            return AlinhamentoCardinal;
        }
    }
}

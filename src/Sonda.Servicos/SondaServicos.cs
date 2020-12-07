namespace Sonda.Servicos
{
    public class SondaServicos : ISondaServicos
    {
        public string DefineAlinhamentoCardinal(string posicaoAtual, string direcaoDoMovimento)
        {
            posicaoAtual = posicaoAtual.ToUpper();
            direcaoDoMovimento = direcaoDoMovimento.ToUpper();

            if(posicaoAtual != "N" && posicaoAtual != "E" && posicaoAtual != "S" && posicaoAtual != "W")
            {
                return "Os pontos cardinais só podem ser N, E, S ou W";
            }
            return new Dominio.SondaDominio().DefineAlinhamentoCardinal(posicaoAtual, direcaoDoMovimento);
        }
    }
}
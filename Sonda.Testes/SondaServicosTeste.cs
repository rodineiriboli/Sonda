using Sonda.Servicos;
using System;
using Xunit;

namespace Sonda.Testes
{
    public class SondaServicosTeste
    {
        [Fact]
        public void SondaServicos_DefineAlinhamentoCardinal_RetornaPosicaoAtual()
        {
            //Arrange
            var sondaServicos = new SondaServicos();

            //Act
            var resultado1 = sondaServicos.DefineAlinhamentoCardinal("n", "L");
            var resultado2 = sondaServicos.DefineAlinhamentoCardinal("N", "R");
            var resultado3 = sondaServicos.DefineAlinhamentoCardinal("E", "R");
            var resultado4 = sondaServicos.DefineAlinhamentoCardinal("e", "l");
            var resultado5 = sondaServicos.DefineAlinhamentoCardinal("S", "R");
            var resultado6 = sondaServicos.DefineAlinhamentoCardinal("S", "l");
            var resultado7 = sondaServicos.DefineAlinhamentoCardinal("W", "R");
            var resultado8 = sondaServicos.DefineAlinhamentoCardinal("W", "l");

            //Assert
            Assert.Equal("W", resultado1);
            Assert.Equal("E", resultado2);
            Assert.Equal("S", resultado3);
            Assert.Equal("N", resultado4);
            Assert.Equal("W", resultado5);
            Assert.Equal("E", resultado6);
            Assert.Equal("N", resultado7);
            Assert.Equal("S", resultado8);
        }
    }
}

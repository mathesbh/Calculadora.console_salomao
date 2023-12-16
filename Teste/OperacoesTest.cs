using Application;

namespace Teste
{
    public class OperacoesTest
    {
        [Theory]
        [InlineData(10, 15, 25)]
        [InlineData(20.8, 5.2, 26)]
        [InlineData(1, 15.8, 16.8)]
        [InlineData(0, 15, 15)]
        [InlineData(-1, 10, 9)]

        public void OperacaoSomar(float n1, float n2, float expected)
        {
            var soma = Operacoes.Somar(n1, n2);

            Assert.Equal(expected, soma);
        }
    }
}
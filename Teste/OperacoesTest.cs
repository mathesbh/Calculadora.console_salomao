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

        [Theory]
        [InlineData(10, 15, -5)]
        [InlineData(20.8, 5.2, 15.6)]
        [InlineData(1, 15.8, -14.8)]
        [InlineData(0, 15, -15)]

        public void OperacaoSubtrair(float n1, float n2, float expected)
        {
            var subtrair = Operacoes.Subtrair(n1, n2);

            Assert.Equal(expected, subtrair);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(150, 5, 30)]
        [InlineData(200, -5, -40)]
        [InlineData(0, 10, 0)]

        public void OperacaoDividir(float n1, float n2, float expected)
        {
            var dividir = Operacoes.Dividir(n1, n2);

            Assert.Equal(expected, dividir);
        }

        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(150, 5, 750)]
        [InlineData(200, -5, -1000)]
        [InlineData(0, 10, 0)]

        public void OperacaoMultiplicar(float n1, float n2, float expected)
        {
            var multiplicar = Operacoes.Multiplicar(n1, n2);

            Assert.Equal(expected, multiplicar);
        }
    }
}
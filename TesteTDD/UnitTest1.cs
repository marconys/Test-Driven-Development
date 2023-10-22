using System;
using Xunit;
using TDD;

namespace TesteTDD
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "21/10/2023";
            Calculadora calc = new Calculadora("21/10/2023");
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Somar(val1, val2);

            Assert.Equal(res, resultado);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Multiplicar(val1, val2);

            Assert.Equal(res, resultado);

        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(6, 5, 1)]
        public void TesteSubtrair(int val1, int val2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Subtrair(val1, val2);

            Assert.Equal(res, resultado);

        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        public void TesteDividir(int val1, int val2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Dividir(val1, val2);

            Assert.Equal(res, resultado);

        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 2);
            calc.Somar(3, 2);
            calc.Somar(8, 2);

            var lista = calc.Historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
        }
    }
}

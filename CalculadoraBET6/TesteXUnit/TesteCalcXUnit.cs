using CalculadoraBET6;

namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 2;
            double tNum = 3;

            //Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);
            
            //Assert - Verificação
            Assert.Equal(tNum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.Equal(tNum, resultado);
        }

    }
}
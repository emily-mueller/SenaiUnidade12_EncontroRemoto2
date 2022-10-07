using CalculadoraBET6;

namespace TestMsTest
{
    [TestClass]
    public class TesteCalcMsTest
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - prepara��o
            double pNum = 1;
            double sNum = 1;
            double tNum = 2;

            //Act - a��o
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - verifica��o
            Assert.AreEqual(tNum, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 5, 7)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(tNum, resultado);
        }

    }
}
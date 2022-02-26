using Company.DecomNumber.Lib.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.DecomNumber.Tests
{
    [TestClass]
    public class UnitTestDecomNumber
    {
        private readonly DecomNumberService _decomNumberService; 

        public UnitTestDecomNumber()
        {
            _decomNumberService = new DecomNumberService();
        }

        /// <summary>
        /// Verificar se metodo retorna uma lista com divisores de um número e seus divisores primos  
        /// </summary>
        [TestMethod]
        public void CheckCalculeDivisoresComNumeroPositivosInteiros()
        {
            long num = 500;

            var retorno = _decomNumberService.CalculeDivisor(num);

            Assert.IsTrue(retorno.NumberDivisores.Count > 0 && retorno.NumberPrimo.Count > 0);

        }

        /// <summary>
        /// Verificar se metodo re
        /// </summary>
        [TestMethod]
        public void CheckCalculeDivisoresComZero()
        {
            long num = 0;

            var retorno = _decomNumberService.CalculeDivisor(num);

            Assert.IsTrue(retorno.NumberDivisores.Count == 1 && retorno.NumberPrimo.Count == 0);
        }

   
        /// <summary>
        /// Verificar se metodo retorna que o número é primo
        /// </summary>
        [TestMethod]
        public void CheckIsNumberPrimoComNumerosPrimos()
        {
            long num = 43;

            var retorno = _decomNumberService.IsNumberPrimo(num);

            Assert.IsTrue(retorno);
        }

        /// <summary>
        /// Verificar se metodo retorna que o número não é primo
        /// </summary>
        [TestMethod]
        public void CheckIsNumberPrimoComNumerosNaoPrimos()
        {
            long num = 10;

            var retorno = _decomNumberService.IsNumberPrimo(num);

            Assert.IsFalse(retorno);
        }

    }
}

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
        public void CheckCalculateDivisorsWithNumberPositives()
        {
            long num = 500;

            var retorno = _decomNumberService.CalculateDivisors(num);

            Assert.IsTrue(retorno.NumbersDivisors.Count > 0 && retorno.NumbersPrime.Count > 0);

        }

        /// <summary>
        /// Verificar se metodo re
        /// </summary>
        [TestMethod]
        public void CheckCalculateDivisorsWithZero()
        {
            long num = 0;

            var retorno = _decomNumberService.CalculateDivisors(num);

            Assert.IsTrue(retorno.NumbersDivisors.Count == 1 && retorno.NumbersPrime.Count == 0);
        }

   
        /// <summary>
        /// Verificar se metodo retorna que o número é primo
        /// </summary>
        [TestMethod]
        public void CheckPrimeNumberWithSuccess()
        {
            long num = 43;

            var retorno = _decomNumberService.IsNumberPrimo(num);

            Assert.IsTrue(retorno);
        }

        /// <summary>
        /// Verificar se metodo retorna que o número não é primo
        /// </summary>
        [TestMethod]
        public void CheckPrimeNumberWithError()
        {
            long num = 10;

            var retorno = _decomNumberService.IsNumberPrimo(num);

            Assert.IsFalse(retorno);
        }

    }
}

using Company.DecomNumber.Lib.Validator;
using System.Collections.Generic;

namespace Company.DecomNumber.Lib.Service
{
    public class DecomNumberService
    {
        /// <summary>
        /// Calcula os divisores de um número e seus números primos 
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public DecomNumber CalculateDivisors(long entrada)
        {

            DecomNumber decomNumber = new DecomNumber
            {
                NumberEntry = entrada,
                NumbersDivisors = new List<long>() { 1 },
                NumbersPrime = new List<long>()
            };
            
            for (long i = 2; i <= entrada; i++)
            {
                if (entrada % i == 0)
                {
                    decomNumber.NumbersDivisors.Add(i);

                    if (IsNumberPrimo(i))
                        decomNumber.NumbersPrime.Add(i);
                }
            }

            return decomNumber;
        }

        /// <summary>
        /// Obtem os números primos de um número 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsNumberPrimo(long number)
        {
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

    }
}

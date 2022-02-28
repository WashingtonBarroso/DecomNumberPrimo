using Company.DecomNumber.Api.Response;
using Company.DecomNumber.Api.ViewModel;
using System;
using Company.DecomNumber.Lib.Service;

namespace Company.DecomNumber.Api.Service
{
    public class CalculeService : ICalculeService
    {
        /// <summary>
        ///  Calcula os divisores de um número e seus numeros primos chamando  a biblioteca de calculo de divisores
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public DecomNumberResponse CalculateDivisors(DecomNumberViewModel entrada)
        {
            DecomNumberService service = new DecomNumberService();

            var response = service.CalculateDivisors(entrada.NumberEntry);

            return new DecomNumberResponse() { NumberEntry = response.NumberEntry, NumberDivisors = response.NumbersDivisors, NumberPrime = response.NumbersPrime }; 
        }
    }
}

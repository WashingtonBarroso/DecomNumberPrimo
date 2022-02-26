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
        public DecomNumberResponse CalculeDivisor(DecomNumberViewModel entrada)
        {
            DecomNumberService service = new DecomNumberService();

            var response = service.CalculeDivisor(entrada.NumberEntrada);

            return new DecomNumberResponse() { NumberEntrada = response.NumberEntrada, NumberDivisores = response.NumberDivisores, NumberPrimo = response.NumberPrimo }; 
        }
    }
}

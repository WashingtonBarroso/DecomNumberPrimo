using Company.DecomNumber.Lib.Service;
using Company.DecomNumber.Lib.Validator;
using System;

namespace Company.DecomNumber.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Divisor números primos \r");
            System.Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>> \n");

            string exit = "";

            while (exit.ToString().ToUpper() != "F")
            {
                System.Console.WriteLine("Informe um valor de entrada: ");
                long.TryParse(System.Console.ReadLine(), out long num);

                DecomNumberValidator validatorNumber = new DecomNumberValidator();
                var validator = validatorNumber.Validate(new Company.DecomNumber.Lib.Service.DecomNumber() { NumberEntry = num });

                if (!validator.IsValid)
                {
                    System.Console.BackgroundColor = ConsoleColor.Red;
                    System.Console.WriteLine(string.Join(",\n", validator.Errors));
                    System.Console.ResetColor();
                }
                else
                {
                    CalculateDivisors(num);
                }

                System.Console.WriteLine();
                System.Console.WriteLine("Informe F para fechar ou qualquer tecla para continuar: ");
                exit = System.Console.ReadLine();
            }

        }

        public static void CalculateDivisors(long num)
        {
            DecomNumberService calc = new DecomNumberService();
            var retorno = calc.CalculateDivisors(num);

            System.Console.WriteLine("Número de entrada: " + num);
            System.Console.WriteLine("Números divisores: " + string.Join(",", retorno.NumbersDivisors));
            System.Console.WriteLine("Divisores primos: " + string.Join(",", retorno.NumbersPrime));
            System.Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>> \n");
        }

    }
}

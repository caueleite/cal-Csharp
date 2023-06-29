using System;
using System.ComponentModel.Design;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha sua operação\n 1 - adição \n 2 - subtração \n 3 - Multiplicação \n 4 - Divisão");
            string pu = Console.ReadLine();

            if (pu == "1")
            {
                Console.WriteLine("Diga Um número");
                String calc = Console.ReadLine();
                int soma = Convert.ToInt32(calc);
                Console.WriteLine("Diga Outro Número");
                String calc2= Console.ReadLine();
                int soma2 = Convert.ToInt32(calc2);
                int Resultado = soma2 + soma;
                Console.WriteLine("O resultado é");
                Console.WriteLine(Resultado);


            }
            else if (pu == "2")
            {
                Console.WriteLine("Diga Um número");
                String calc = Console.ReadLine();

                int subtracao = Convert.ToInt32(calc);

                Console.WriteLine("Diga Outro Número");
                String calc2 = Console.ReadLine();

                int subtracao2 = Convert.ToInt32(calc2);

                int Resultado = subtracao - subtracao2;
                Console.WriteLine("O resultado é");
                Console.WriteLine(Resultado);
            }
            else if (pu == "3")
            {
                Console.WriteLine("Diga Um número");
                String calc = Console.ReadLine();

                int subtracao = Convert.ToInt32(calc);

                Console.WriteLine("Diga Outro Número");
                String calc2 = Console.ReadLine();

                int subtracao2 = Convert.ToInt32(calc2);

                int Resultado = subtracao * subtracao2;
                Console.WriteLine("O resultado é");
                Console.WriteLine(Resultado);
            }
            else if (pu == "4")
            {
                Console.WriteLine("Diga Um número");
                String calc = Console.ReadLine();

                int subtracao = Convert.ToInt32(calc);

                Console.WriteLine("Diga Outro Número");
                String calc2 = Console.ReadLine();

                int subtracao2 = Convert.ToInt32(calc2);

                int Resultado = subtracao / subtracao2;
                Console.WriteLine("O resultado é");
                Console.WriteLine(Resultado);
            }

            Console.ReadKey();
        }
    }
}
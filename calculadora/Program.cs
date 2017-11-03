using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            
            Console.WriteLine("Bem-vindo à Calculadora Básica.");
            Console.WriteLine("Digite um número: ");
            string tmp = Console.ReadLine();
            num1 = double.Parse(tmp);
            Console.WriteLine("Digite mais um número: ");
            tmp = Console.ReadLine();
            num2 = double.Parse(tmp);
            
            Console.WriteLine();
            double resultado = num1 + num2;
            Console.WriteLine("Soma: " + resultado + ".");
            resultado = num1 - num2;
            Console.WriteLine("Subtração: " + resultado + ".");
            resultado = num1 * num2;
            Console.WriteLine("Multiplicação: " + resultado + ".");
            resultado = num1 / num2;
            Console.WriteLine("Divisão: " + resultado + ".");

            Console.WriteLine();
            Console.WriteLine("Agradecemos a preferência, volte sempre.");
               
        }
    }
}

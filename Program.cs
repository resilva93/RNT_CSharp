using System;
using System.Runtime.Intrinsics.X86;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operacao = int.Parse(Console.ReadLine());
            float resultado = 0;
            switch (operacao)
            {
                case 1:
                    resultado = v1 + v2;
                    break;
                case 2:
                    resultado = v1 - v2;
                    break;
                case 3:
                    resultado = v1 * v2;
                    break;
                case 4:
                    resultado = v1 / v2;
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("O resultado é: "+ resultado);

        }
    }
}
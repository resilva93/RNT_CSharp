using System;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("## Processo - SOMA ##");
            Soma();
            Console.WriteLine("###########################");
            Console.WriteLine("## Processo - SUBTRAÇÃO ##");
            Subtracao();
            Console.WriteLine("###########################");
            Console.WriteLine("## Processo - MULTIPLICAÇÃO ##");
            Multiplicacao();
            Console.WriteLine("###########################");
            Console.WriteLine("## Processo - DIVISÃO ##");
            Divisao();
            Console.WriteLine("###########################");
            Console.WriteLine("## Processo - POTENCIAÇÃO ##");
            Potenciacao();
            Console.WriteLine("###########################");
            Console.WriteLine("## Fim do programa. ##");

        }
        static void Soma()
        {
            Console.WriteLine("Executando a função de soma...");
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

        }
        static void Subtracao()
        {
            Console.WriteLine("Executando a função de subtração...");
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Executando a função de multiplicação...");
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        }
        static void Divisao()
        {
            Console.WriteLine("Executando a função de divisão...");
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            if (v2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return;
            }
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }
        static void Potenciacao()
        {
            Console.WriteLine("Executando a função de potenciação...");
            Console.WriteLine("Digite a base: ");
            double baseNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            double expoente = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expoente);
            Console.WriteLine($"O resultado da potenciação é: {resultado}");
        }

    }
}
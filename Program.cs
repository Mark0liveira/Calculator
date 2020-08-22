using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuMin();
        }

        // static void Menu()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Bem vindo a calculadora do DOS!");
        //     Console.WriteLine("Digite '1' para somar dois números");
        //     Console.WriteLine("Digite '2' para subtrair dois números");
        //     Console.WriteLine("Digite '3' para dividir dois números");
        //     Console.WriteLine("Digite '4' para multiplicar dois números");
        //     Console.WriteLine("Digite '5' para sair");

        //     Console.WriteLine("Digite uma opção:");

        //     var res = short.Parse(Console.ReadLine());

        //     switch (res)
        //     {
        //         case 1:
        //             Soma();
        //             break;
        //         case 2:
        //             Subtracao();
        //             break;
        //         case 3:
        //             Divisao();
        //             break;
        //         case 4:
        //             Multiplicacao();
        //             break;
        //         default:
        //             Sair();
        //             break;
        //     }
        // }

        static void Sair()
        {
            System.Environment.Exit(0);
            Console.Clear();
        }

        // static void Soma()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Digite o primeiro número");
        //     float v1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Digite o segundo número");
        //     float v2 = float.Parse(Console.ReadLine());

        //     var resultado = v1 + v2;
        //     // Console.WriteLine("O resultado da soma é: " + (v1 + v2));
        //     Console.WriteLine($"O resultado da soma é: {resultado}");
        //     // Console.WriteLine($"O resultado da soma é: {v1 + v2}");

        //     Console.ReadKey();

        //     Menu();
        // }

        // static void Subtracao()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Digite o primeiro valor");
        //     float v1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Digite o segundo valor");
        //     float v2 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("");

        //     var resultado = v1 - v2;
        //     Console.WriteLine($"O resultado é: {resultado}");

        //     Console.ReadKey();

        //     Menu();
        // }

        // static void Divisao()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Digite o primeiro valor:");
        //     float v1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Digite o segundo valor:");
        //     float v2 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("");

        //     var resultado = v1 / v2;

        //     Console.WriteLine($"O resultado é: {resultado}");

        //     Console.ReadKey();

        //     Menu();
        // }

        // static void Multiplicacao()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Digite o primeiro valor:");
        //     float v1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Digite o segundo valor:");
        //     float v2 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("");

        //     var resultado = v1 * v2;

        //     Console.WriteLine($"O resultado é: {resultado}");

        //     Console.ReadKey();

        //     Menu();
        // }

        static void MenuMin()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo a calculadora do DOS!");
            Console.WriteLine("Digite '1' para somar dois números");
            Console.WriteLine("Digite '2' para subtrair dois números");
            Console.WriteLine("Digite '3' para dividir dois números");
            Console.WriteLine("Digite '4' para multiplicar dois números");
            Console.WriteLine("Digite '5' para sair");

            Console.WriteLine("Digite uma opção:");

            var res = short.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            var v2 = float.Parse(Console.ReadLine());

            Calculator(v1, v2, res);
        }

        static void Calculator(float v1, float v2, short operation)
        {
            float res = 0;
            switch (operation)
            {
                case 1: res = v1 + v2; break;
                case 2: res = v1 - v2; break;
                case 3: res = v1 / v2; break;
                case 4: res = v1 * v2; break;
                case 5: Sair(); break;
                default: MenuMin(); break;
            }

            Console.WriteLine(res);
        }
    }
}

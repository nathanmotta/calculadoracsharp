using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;
        char operador;

        Console.WriteLine("Calculadora em C#\n");

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o operador (+, -, *, /): ");
        operador = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero.");
                    Environment.Exit(0);
                }
                break;
            default:
                Console.WriteLine("Operador inválido!");
                Environment.Exit(0);
                break;
        }

        Console.WriteLine($"O resultado é: {resultado}");
    }
}

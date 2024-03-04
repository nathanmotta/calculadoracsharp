using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string nome, genero;
        int salario, idade;
        float altura;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu salário: ");
        salario = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua altura: ");
        altura = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu Gênero (M/F): ");
        genero = Console.ReadLine();

        Console.ReadKey();
    }
}

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string nome, genero;
        int idade, salario;
        float altura;

        Console.WriteLine("Digite um nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite um gênero (F/M): ");
        genero = Console.ReadLine();

        Console.WriteLine("Digite uma idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um salário: ");
        salario = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite uma altura: ");
        altura = float.Parse(Console.ReadLine());

        Console.WriteLine("Resultado: ");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Genero: " + genero);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Altura: " + altura);

        Console.ReadKey();
    }
}

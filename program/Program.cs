using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine();

        }
    }
}
using System;


namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Digite o Comprimento:");
            r.comprimento = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite a Largura:");
             r.largura = double.Parse(Console.ReadLine());

            
            Console.WriteLine($"A Area do Retagunlo é: {r.ObterArea()}");

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsvStream
{
    public class Ler
    {
        public void LerCsv()
        {
            var caminho = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios-exportados.csv");
            using var lendo = new StreamReader(caminho);

            var cabecalho = lendo.ReadLine()?.Split(',');

            while (true)
            {
                var registro = lendo.ReadLine()?.Split(',');

                if (registro == null) break;

                for (int i = 0; i < registro.Length; i++)
                {
                    System.Console.WriteLine($"{cabecalho?[i]}:{registro[i]}");
                }
                System.Console.WriteLine("------------------------");
            }
            System.Console.WriteLine("Pressione ENTER para finalizar");
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsvStream
{
    public class Criar
    {
        public void CriarCsv()
        {
            var caminho = Path.Combine(Environment.CurrentDirectory, "Saida");
            var pessoas = new List<Pessoa>()
            {
               new Pessoa()
            {
                Nome = "Rafael samary",
                Email = "rafael@hotmail",
                Telefone = 99588412,
                Nascimento = new DateOnly(year:1973, month: 1, day: 11)
            },
               new Pessoa()
            {
                Nome = "Paulo da silva",
                Email = "paulo@hotmail",
                Telefone = 98554170,
                Nascimento = new DateOnly(year:1985, month: 11, day: 23)
            },
               new Pessoa()
            {
                Nome = "Renata lugon",
                Email = "renata@hotmail",
                Telefone = 99855514,
                Nascimento = new DateOnly(year:1975, month: 5, day: 25)
            },
               new Pessoa()
            {
                Nome = "Regina Lugon",
                Email = "reginal@hotmail",
                Telefone = 99552471,
                Nascimento = new DateOnly(year:2001, month: 10, day: 22)
            }
            };
            

            var dir = new DirectoryInfo(caminho);
            if(!dir.Exists)
            {
                dir.Create();
                caminho = Path.Combine(caminho,"usuarios-criados.csv");
            }
            using var escrever = new StreamWriter(caminho);
            escrever.WriteLine("Nome,Email,Telefone,Nascimento");
            foreach (var pessoa in pessoas)
            {
                var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
                escrever.WriteLine(linha);
            }
            escrever.Flush();
            System.Console.WriteLine("Pressione ENTER para finalizar");
            Console.ReadLine();
        }

        class Pessoa
        {
            public string Nome {get; set;}
            public string Email {get; set;}
            public int Telefone {get; set;}
            public DateOnly Nascimento {get; set;}
        }
    }
}
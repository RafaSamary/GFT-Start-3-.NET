using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;


      
        public Pessoa(string nome, string sobrenome) // construtor definindo parametros 
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Classe");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, Meu nome é: {nome} {sobrenome}");
        }
    }
}
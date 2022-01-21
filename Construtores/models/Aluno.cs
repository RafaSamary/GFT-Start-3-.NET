using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Aluno : Pessoa   // herança da classe e parametros dela na ordem de herarquia 
    {
        public Aluno(string nome, string sobrenome, string disciplina) : base (nome, sobrenome)
        {
            System.Console.WriteLine("Construtor da classe Aluno");
        }
    }
}
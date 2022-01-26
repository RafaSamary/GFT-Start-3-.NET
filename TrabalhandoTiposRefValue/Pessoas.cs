using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class Pessoas
    {
        public int Idade {get; set;}
        public string Nome {get; set;}
        public string Documento {get; set;}

        public Pessoas Clone()
        {
            return new Pessoas()
            {
                Documento = this.Documento,
                Idade = this.Idade,
                Nome = this.Nome,
            };
        }
      
    }
    
}

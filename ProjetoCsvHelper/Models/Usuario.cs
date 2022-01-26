using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCsvHelper.Models
{
    public class Usuario
    {
        public string Nome {get; set;}
        public string Email {get; set;}
        public long Telefone {get; set;}
        public string Nascimento {get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Matematica
    {
        public int  x { get; set; }       
        public int y { get; set; }

        public Matematica(int num1, int num2)
        {
          x =  num1;
          y =  num2;

          CalculadoraDelegate.EventoCalculadora += EventHandle;
        }

        public void Somar()
        {
            Caculadora.Somar(x, y);
        }

        public void EventHandle()
        {
            System.Console.WriteLine("Método executado");
        }
    }
}
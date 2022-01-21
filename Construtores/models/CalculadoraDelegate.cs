using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class CalculadoraDelegate
    {
        public delegate void DelegateCaculadora();
        
         public static event DelegateCaculadora EventoCalculadora;

         public static void Somar(int num1, int num2)
         {
             if( EventoCalculadora != null)
             {
                 System.Console.WriteLine($"Adição: {num1 + num2}");
                 EventoCalculadora();
             }         
         else
         {
           System.Console.WriteLine("Nenhum Numero");
         }
        
    }
  }
}
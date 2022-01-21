using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Data
    {
        private int mes;
        private bool mesValido;

       public int Mes
       {
           get
           { 
               return this.mes;
           }

           set
           {
               if(value > 0 && value <=12)
               {
                   this.mes = value;
                   this.mesValido = true;
               }
           }
       }

         public void ApresentarMes()
            {
                if(this.mesValido)
                {
                 System.Console.WriteLine(this.mes);
                }
               else
               {
                   System.Console.WriteLine("Mês Inválido");
               } 
            }

    }
}
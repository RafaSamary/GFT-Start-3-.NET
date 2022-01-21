using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Caculadora
    {
        public static void Somar(int num1, int num2)
        {
            System.Console.WriteLine($"Adição: {num1 + num2}");
        }
         public static void Subtrair(int num1, int num2)
        {
            System.Console.WriteLine($"Subtração: {num1 - num2}");
        }
    }
}
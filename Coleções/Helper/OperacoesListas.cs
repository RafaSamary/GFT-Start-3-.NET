using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coleções.Helper
{
    public class OperacoesListas
    {
        public void ImprimirLista(List<string> lista)
        {
              for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Índice {i}, Valor; {lista[i]}");
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diretórios
{
    public class Mover
    {
        public void MoverArquivos(string pathOrigem, string pathDestino)
        {
            if(!File.Exists(pathOrigem))
            {
                System.Console.WriteLine("Arquivo de origem não Existe");
                return;
            }
             if(File.Exists(pathDestino))
            {
                System.Console.WriteLine("Arquivo já Existe na pasta destino");
                return;
            }
                        
            File.Move(pathOrigem, pathDestino);
        }
    }
}
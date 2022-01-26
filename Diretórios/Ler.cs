using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diretórios
{
    public class Ler
    {
        public void LerAquivos(string path)
        {
            var arquivos = Directory.GetFiles(path,"*",SearchOption.AllDirectories);

            foreach( var arquivo in arquivos)
            {
                var fileInfo = new FileInfo(arquivo);
                System.Console.WriteLine($"[Nome]:{fileInfo.Name}");
                System.Console.WriteLine($"[Tamnho]:{fileInfo.Length}");
                System.Console.WriteLine($"[Ultimo acesso]:{fileInfo.LastAccessTime}");
                System.Console.WriteLine($"[Pasta]:{fileInfo.DirectoryName}");
                System.Console.WriteLine("-------------------------------------");
            }
             System.Console.WriteLine("Digite ENTER para finalizar:");
             Console.ReadLine();
        }
    }
}
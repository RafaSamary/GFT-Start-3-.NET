using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diretórios
{
    public class Listar
    {
        public void ListarDiretorios(string path)
        {

            if(Directory.Exists(path))
            {
                var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                foreach (var dir in diretorios)
                {
                    var dirInfo = new DirectoryInfo(dir);
                    System.Console.WriteLine($"[Nome]:{dirInfo.Name}");
                    System.Console.WriteLine($"[Raiz]:{dirInfo.Root}");

                    if (dirInfo != null)

                        System.Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");

                    System.Console.WriteLine("-----------------------");


                }
            }
            else
            {
                System.Console.WriteLine("Caminho para o Diretorio ou Dretorio não Existe!");
            }

            System.Console.WriteLine("Digite ENTER para finalizar:");
            Console.ReadLine();

        }
    }
}
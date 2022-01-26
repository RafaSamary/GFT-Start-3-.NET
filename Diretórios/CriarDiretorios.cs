using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diretórios
{
    public class CriarDiretorios
    {

        public void CriarDiretoriosGlobo()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "globo");

            if(!Directory.Exists(path))
            {

                var dirGlobo = Directory.CreateDirectory(path);
                var dirAmNorte = dirGlobo.CreateSubdirectory("America do Norte");
                var dirAmCentral = dirGlobo.CreateSubdirectory("America Central");
                var dirAmSul = dirGlobo.CreateSubdirectory("America do Sul");

                dirAmNorte.CreateSubdirectory("USA");
                dirAmNorte.CreateSubdirectory("MEXICO");
                dirAmNorte.CreateSubdirectory("CANADA");

                dirAmCentral.CreateSubdirectory("COSTA RICA");
                dirAmCentral.CreateSubdirectory("PANAMA");

                dirAmSul.CreateSubdirectory("BRASIL");
                dirAmSul.CreateSubdirectory("ARGENTINA");
                dirAmSul.CreateSubdirectory("PARAGUAI");
            }
         
        }
            

    }
}
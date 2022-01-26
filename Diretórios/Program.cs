using System;

namespace Diretórios
{
    class Program
    {
        public static void Main(string[] args)
        {
            // var criarPastas = new CriarDiretorios();
            // criarPastas.CriarDiretoriosGlobo();

            // var criarTxt = new CriarArquivos();
            // criarTxt.CriarArquivosNovos();

    //___________________________________________________________________________________________________

            // var origem = Path.Combine(Environment.CurrentDirectory,"Brasil.txt");
            // var destino = Path.Combine(Environment.CurrentDirectory,"globo","America do Sul","BRASIL","Brasil.txt");
            
            // var mover = new Mover();
            // mover.MoverArquivos(origem, destino);

    //___________________________________________________________________________________________________ 

            // var caminho = @"C:\workspace\BootCampGFT\GFT-Start-3-.NET\Diretórios\globo";

            // var dir = new Listar();
            // dir.ListarDiretorios(caminho);
           
     //___________________________________________________________________________________________________ 

           var caminho = @"C:\workspace\BootCampGFT\GFT-Start-3-.NET\Diretórios\globo";

           var l = new Ler();
           l.LerAquivos(caminho);

            

        }
    }
}

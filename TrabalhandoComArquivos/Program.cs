
using System;
using System.IO;
using System.Collections.Generic;



namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {   
            var caminho = "C:\\TrabalhandoComDiretorios";            
            var PathCombine = Path.Combine(caminho, "Pasta1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var novoCaminho = Path.Combine(caminho, "Pasta2", "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia= Path.Combine(caminho, "arquivo-teste-copia.txt");


            var listastring = new List<string> { "Linha 1", "Linha 2", "Linha 3"};
            var listastringContinuação  = new List<string> { "Linha 4", "Linha 5", "Linha 6"};

            
            FileHelper helper =  new FileHelper();

            //helper.ListarDiretorio(caminho);

            //helper.ListarArquivos(caminho);

            //helper.CriarDiretorio(PathCombine));

            //helper.ApagarDiretorio(PathCombine, true);

            //helper.CriarArquivoTexto(caminhoArquivo, "Olá Teste de Escrita de Arquivo!");

            //helper.CriarArquivoStream(caminhoArquivo, listastring);

            //helper.AdicionarArquivoStream(caminhoArquivo, listastringContinuação);

            //helper.LerAquivosStream(caminhoArquivo);

            //helper.MoverAquivo(caminhoArquivo, novoCaminho, false);
            
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            helper.DeletarArquivo(caminhoArquivoTesteCopia);

        }
    }
}

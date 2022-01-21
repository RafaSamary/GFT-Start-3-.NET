using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    public class FileHelper
    {
        public void ListarDiretorio(string caminho)
        {
            var retornoDiretorio = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach(var retorno in retornoDiretorio)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivos(string caminho)
        {
            var retornoArquivo = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach(var retorno in retornoArquivo)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio( string caminho)
        {
            var criar = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(criar.FullName);
        }

        public void ApagarDiretorio(string camimho, bool apagarArquivos)
        {
            Directory.Delete(camimho, apagarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        { 
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
            
        }

        public void CriarArquivoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
          public void  AdicionarArquivoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach( var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerAquivosStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverAquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho,  sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
         
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diretórios
{
    public class CriarArquivos
    {
        public void CriarArquivosNovos()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
            if(!File.Exists(path))
            {
                
                var sw = File.CreateText(path);
                sw.WriteLine("População: 313 milhões");
                sw.WriteLine("IDH: 0,901");
                sw.WriteLine("Dados atualizados: 25/01/2022");
                sw.Flush();
            }
            
        }
    }
}
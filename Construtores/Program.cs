using System;
using Construtores;

namespace Construtores
{
    class Program
    {
        public delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {   

            Matematica mat = new Matematica(10, 20);
            mat.Somar();

            // Operacao op = new Operacao(Caculadora.Somar);
            // op += Caculadora.Subtrair;
            // op.Invoke(10, 10);

            // const double pi = 3.14;
            // System.Console.WriteLine(pi);            

            // Data data = new Data();
            // data.Mes = 12;
            // data.ApresentarMes();
              
             // Aluno p1 = new Aluno("Rafael", "Samary", "Desenvolvimento");
             // p1.Apresentar();

             // Log log = Log.GetInstance();
             // log.PropriedadeLog = "Teste Instancia";
             // System.Console.WriteLine(log.PropriedadeLog);

            // Pessoa p1 = new Pessoa("Rafel", "Samary");
            // p1.Apresentar();
           
        }
    }
}
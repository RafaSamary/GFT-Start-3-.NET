// See https://aka.ms/new-console-template for more information
using System;


namespace Revisao{

    class Program{

        static void Main(string[] args)
        {
               Aluno[] alunos = new Aluno[5];
               var IndiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {

                    case "1":
                        Console.WriteLine("Informe o Nome do Aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a Nota do Aluno:");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                               aluno.Nota = nota;
                        }
                        else{
                            throw new ArgumentException("Valor da Nota deve ser decimal");
                        }

                             alunos[IndiceAluno] = aluno;
                             IndiceAluno++;
                        break;

                    case "2":

                        foreach(var listar in alunos)
                        {
                            if(!string.IsNullOrEmpty(listar.Nome))
                            {
                                Console.WriteLine($"Aluno:  {listar.Nome}  -  Nota:   {listar.Nota}");
                            }
                             
                        }


                        break;

                    case "3":

                        decimal notaTotal = 0;
                        var mrAlunos = 0;

                        for(int i = 0; i < alunos.Length; i++)
                        {
                                 if(!string.IsNullOrEmpty(alunos[i].Nome))
                                 {
                                     notaTotal = notaTotal + alunos[i].Nota;
                                     mrAlunos++;
                                 }

                        }

                            var mediaGeral = notaTotal / mrAlunos;
                            Conceito conceitoEnum;

                             if(mediaGeral < 2)
                             {
                                 conceitoEnum = Conceito.E;
                             }
                             else if(mediaGeral < 4)
                             {
                                 conceitoEnum = Conceito.D;
                             }
                             else if(mediaGeral < 6)
                             {
                                 conceitoEnum = Conceito.C;
                             }
                               else if(mediaGeral < 8)
                             {
                                 conceitoEnum = Conceito.B;
                             }
                             else
                             {
                                 conceitoEnum = Conceito.A;
                             }

                            Console.WriteLine($"Media Geral: {mediaGeral} - Conceito: {conceitoEnum}");


                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                   opcaoUsuario = ObterOpcaoUsuario();
                
            }

       }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("***Informe a opção Desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}

   


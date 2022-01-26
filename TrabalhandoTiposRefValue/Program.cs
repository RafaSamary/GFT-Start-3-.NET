using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    
    
    

    class Program 
    {
       
        
        static void TrocarNome(Pessoas p1, string nomeNovo)
          {
            p1.Nome = nomeNovo;
          }

          static StructPessoas TrocarNomeStruct(StructPessoas p1, string nomeNovo)
          {
             p1.Nome = nomeNovo;
             return p1;
          }

          static void TrocarNome(string nome, string nomeNovo)
          {
              nome = nomeNovo;
          }         

        static int Adicionar20(int a)
        {
            return  a + 20;
        }
        static void MudarParaImpar(int[] pares)
        {
           for(int i = 0; i < pares.Length; i++)
           {
             pares[i] = pares[i] + 1;
           }     
        }

        static void Adicionar20(ref int a)
        {
          a += 20;
        }
       
        public static void Main(string[] args)
        {    
           
           int a =5;
           Adicionar20(ref a);
           System.Console.WriteLine($"O valor de a é: {a}"); // USANDO PALAVRA RESERVADA REF

   //__________________________________________________________________________________________________

          // int[] numeros = new int[] {0,2,4,6,8};
          // System.Console.WriteLine($"Digite o numero para localizar");
          // var numero = int.Parse(Console.ReadLine());
          // var indexEncontrado = (numeros, numero);
          // if(indexEncontrado >= 0)
          // {
          //    System.Console.WriteLine($"O numero digitado: {numero}, foi encontrado na posição: {indexEncontrado}");
          // }
          // else
          // {
          //   System.Console.WriteLine($"O numero: {numero}, não foi encontrado"); 
          //  }
         

 //__________________________________________________________________________________________________
          // int[] pares = new int[]{0,2,4,6,8};

          // MudarParaImpar(pares);

          // System.Console.WriteLine($"Os impares: {string.Join(", ", pares)}");

//__________________________________________________________________________________________________

          // string nome = "Rafael";
          // TrocarNome(nome, "José");
          // System.Console.WriteLine($"O novo nome é {nome}"); // não altera 

//__________________________________________________________________________________________________

          // StructPessoas p1 = new StructPessoas
          // {
          //     Nome = "Rafael",
          //     Idade = 49,
          //     Documento = "1234",
          // };

          // StructPessoas p2 = p1;

          // p1 = TrocarNomeStruct(p1, "João");
          // System.Console.WriteLine($@"
          //      O Nome de p1 é: {p1.Nome}
          //      O Nome de p2 é: {p2.Nome}
          //       ");


    //__________________________________________________________________________________________________


            // Pessoas p1 = new Pessoas();  // REF TYPES - COPIA NA HEAP

            //  p1.Nome = "Rafael";
            //  p1.Idade = 49;
            //  p1.Documento = "1234"; 

            //  Pessoas p2 = p1.Clone();            

            //   TrocarNome(p1, "José");

            //   System.Console.WriteLine($@"
            //    O Nome de p1 é: {p1.Nome}
            //    O Nome de p2 é: {p2.Nome}
            //    ");

          //__________________________________________________________________________________________________

            // Pessoas p1 = new Pessoas();  // REF TYPES - COPIA NA HEAP

            // p1.Nome = "Rafael";
            // p1.Idade = 49;
            // p1.Documento = "1234";           
           
            // TrocarNome(p1, "José");
            // System.Console.WriteLine($"O Novo nome é: {p1.Nome}");           

//__________________________________________________________________________________________________

            //    int a = 2;
            //    a = Adicionar20(a);
            //    System.Console.WriteLine($"O valor da variavel é: {a}"); // VALUE TYPES - COPIA NA STACK

        }
    }
}

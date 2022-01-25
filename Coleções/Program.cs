using System;
using Coleções.Helper;

namespace Coleções
{
    class Program
    {
         static void Main(string[] args)
        { 
            int [] arrayNumeros = new int[10] {100,1,4,0,8,15,19,19,4,100}; // SOMA E METODO DISTINCT

              var soma = arrayNumeros.Sum();
              var arrayUnico = arrayNumeros.Distinct().ToArray();

              System.Console.WriteLine($"A soma dos valores do Array é: {soma}");
              System.Console.WriteLine($"Array Original: {string.Join(", ", arrayNumeros)}");
              System.Console.WriteLine($"Array Distinto: {string.Join(", ", arrayUnico)}");
 //___________________________________________________________________________________________________________________________________________ 

            // int [] arrayNumeros = new int[7] {100,1,4,0,8,15,19}; // BUSCA NUMEROS MAX, MIN E MEDIO NO ARRAY

            // var minimo  = arrayNumeros.Min();
            // var maximo  = arrayNumeros.Max();
            // var medio  = arrayNumeros.Average();

            // System.Console.WriteLine($"Minimo: {minimo}");
            // System.Console.WriteLine($"Maximo: {maximo}");
            // System.Console.WriteLine($"Medio: {medio}");            

//___________________________________________________________________________________________________________________________________________ 


            //   var numerosParesQuery =                          // LINQ - QUERY 
            //            from num in arrayNumeros
            //            where num %2 == 0
            //            orderby num 
            //            select num;
            // //____________________________________________________________________________________________________            

            //    var numerosParesMetodo = arrayNumeros.Where(x => x %2 == 0).OrderBy(x => x).ToList();  // LINQ - METODO 

            //    System.Console.WriteLine("Numeros pares QUERY: " + string.Join(", ", numerosParesQuery));
            //    System.Console.WriteLine("Numeros pares METODO: " + string.Join(", ", numerosParesMetodo));           


//___________________________________________________________________________________________________________________________________________    


            //    Dictionary<string, string> estados = new Dictionary<string, string>();

            //    estados.Add("SP", "SÃO PAULO");
            //    estados.Add("MG", "MINAS GERAIS");
            //    estados.Add("BA", "BAHIA");

            //    foreach (KeyValuePair<string, string> item in estados) // LENDO OAS CHAVES E VALORES DO DICIONARIO
            //     {
            //      System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            //     }

            //     string valorProcurado = "SC";

            //     if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            //     {
            //         System.Console.WriteLine(estadoEncontrado);
            //     }
            //     else
            //     {
            //         System.Console.WriteLine($"Chave: {valorProcurado} não existe no Dicionario");
            //     }


            //____________________________________________________________________________________________________ 

            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "SÃO PAULO");
            // estados.Add("MG", "MINAS GERAIS");
            // estados.Add("BA", "BAHIA");


            //  System.Console.WriteLine();
            //  System.Console.WriteLine("Dicionario original:");
            //  System.Console.WriteLine();
            //  foreach (KeyValuePair<string, string> item in estados) // LENDO OAS CHAVES E VALORES DO DICIONARIO
            //  {
            //      System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            //  }

            //   string valorProcurado = "BA";

            //   System.Console.WriteLine($"Removendo o valor:{valorProcurado}");
            //   estados.Remove(valorProcurado);

            //    System.Console.WriteLine();
            //    System.Console.WriteLine("Dicionario Atualizado:");
            //    System.Console.WriteLine();
            //    foreach (KeyValuePair<string, string> item in estados) // LENDO OAS CHAVES E VALORES DO DICIONARIO
            //  {
                 
            //      System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            //  }

               
           //____________________________________________________________________________________________________ 


            //  System.Console.WriteLine("Valor original:");
            //  System.Console.WriteLine(estados[valorProcurado]);

            //  estados[valorProcurado] = "BA - Teste atualização";
            //  System.Console.WriteLine(estados[valorProcurado]);          


            //____________________________________________________________________________________________________ 

            //  Stack<string> pilhaLivros = new Stack<string>(); // CRIANDO UMA PILHA LIFO (LAST IN FIRST OUT)

            //  pilhaLivros.Push(".NET");
            //  pilhaLivros.Push("DDD");
            //  pilhaLivros.Push("CODIGO LIMPO");

            //  System.Console.WriteLine($"Livros para Leitura: {pilhaLivros.Count}");

            //  while(pilhaLivros.Count > 0)
            //  {
            //      System.Console.WriteLine($"Próximo Livro para a Leitura: {pilhaLivros.Peek()}");
            //       System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            //  }
            //  System.Console.WriteLine($"Livros para Leitura: {pilhaLivros.Count}");

             //____________________________________________________________________________________________________ 

            // Queue<string> fila =  new Queue<string>();  // CRIANDO UM FILA FIFO (FIRST IN FIRST OUT)

            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("André");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while(fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()}  atendido");
            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            

            //____________________________________________________________________________________________________ 


            //OperacoesListas opLista = new OperacoesListas();    

           // List<string> estados = new List<string>() {"SP","MG","BA"};
            //string[] estadosArray = new string[2] {"SC","MT"};            

            // System.Console.WriteLine($"Quantidade de elementos: {estados.Count}");
            // opLista.ImprimirLista(estados);          
             

            //estados.AddRange(estadosArray);

             // estados.Insert(1, "RJ"); // ADICIONANDO EM UM INDICE EXPECIFICO

        

            // System.Console.WriteLine("Removendo um elemento da Lista");
            // estados.Remove("MG");
            // System.Console.WriteLine($"Novos itens Adicionados na lista ");
             //opLista.ImprimirLista(estados);
            // System.Console.WriteLine($"Quantidade de elementos: {estados.Count}");
          
          

          //____________________________________________________________________________________________________ 



                //  int[] array = new int[5] {6,3,8,1,9};   // CONVERTENDO ARRAY PARA STRING            

                //  OperacoesArray op = new OperacoesArray(); 

                // string[] arrayString = op.ConvertArrayString(array);              
                 

            //____________________________________________________________________________________________________ 

            //   int[] array = new int[5] {6,3,8,1,9};               

            //    OperacoesArray op = new OperacoesArray();               

            //    System.Console.WriteLine($"Capacidade Atual do Array: {array.Length}");               
            //    op.ImprimirArray(array);
            //    op.RedimensionarArray(ref array, 10);

            //    System.Console.WriteLine($"Após Redimensionar: {array.Length}");
            //    op.ImprimirArray(array);


            //____________________________________________________________________________________________________ 


            //    int[] array = new int[5] {6,3,8,1,9};               

            //    OperacoesArray op = new OperacoesArray();

            //    int valorProcurado = 9;

            //    int indice = op.BuscarIndice(array, valorProcurado);

            //    if(indice > -1)
            //    {
            //        System.Console.WriteLine($"O indice do elemento {valorProcurado} é: {indice}");
            //        op.ImprimirArray(array);
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Valor não existente");
            //        op.ImprimirArray(array);
            //    }


           //____________________________________________________________________________________________________ 


            //     int[] array = new int[5] {6,3,8,1,9};               

            //    OperacoesArray op = new OperacoesArray();
               
            //    int valorProcurado = 15;
            //    int valorAchado = op.ObterValor(array, valorProcurado );
               
            //    if(valorAchado > 0)
            //    {
            //        System.Console.WriteLine("Encontrei o valor {0}:", valorProcurado);
            //        op.ImprimirArray(array);
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Não encontrado {0}:", valorProcurado, array);
            //        op.ImprimirArray(array);
            //    }



            //____________________________________________________________________________________________________ 

              // int[] array = new int[5] {6,3,8,1,9};
            
             //   int valorProcurado = 5;
            //    bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            //    if(todosMaiorQue)
            //    {
            //        System.Console.WriteLine("Todos os valores são maior que {0}:", valorProcurado);
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Existe valores que não  são maior que {0}:", valorProcurado);
            //    }

        //____________________________________________________________________________________________________ 

            // int[] array = new int[5] {6,3,8,1,9};

            //    int valorProcurado = 5;
            //    bool existe = op.Existe(array, valorProcurado);

            //    if(existe)
            //    {
            //        System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            //    }
            //    else{
            //        System.Console.WriteLine("Não encontrado");
            //    }


                //____________________________________________________________________________________________________ 

                // int[] array = new int[5] {6,3,8,1,9};
                // int[] arrayCopia = new int[10];

               //  OperacoesArray op = new OperacoesArray();

                // System.Console.WriteLine("Array Antes da Copia");
                // op.ImprimirArray(arrayCopia);

                // op.CopiarArray(ref array, ref arrayCopia);
                // System.Console.WriteLine("Array Depois da Copia");
                //  op.ImprimirArray(arrayCopia);

             //____________________________________________________________________________________________________ 


               //int[] array = new int[5] {6,3,8,1,9};                

              // OperacoesArray op = new OperacoesArray();

              // System.Console.WriteLine("Array original:");
               //op.ImprimirArray(array);

               // System.Console.WriteLine("Array Ordenado:");
               // op.OrdenarBublleSort(ref array); // codigo proprio 
               //op.OrdenarArray(ref array); // metodo nativo Array.sort()
              // op.ImprimirArray(array);


             //____________________________________________________________________________________________________ 



            //   int[,] matriz = new int[4,2] { 
            //                          // Array multidimencional 4 linhas e 2 colunas
            //       {8,8},
            //       {10,20},
            //       {50,100},
            //       {90,200},                
                                    
            //       }; 

            //       for(int linha = 0; linha < matriz.GetLength(0); linha++)  // percorre a linha
            //       {
            //            for(int coluna =0; coluna < matriz.GetLength(1); coluna++)  // percorre a coluna
            //       {
            //                 System.Console.WriteLine(matriz[linha, coluna]);
            //       }
            //       }

             //____________________________________________________________________________________________________ 
 

        //    int[] arrayInteiros = new int[3];

        //    arrayInteiros[0] = 10;
        //    arrayInteiros[1] = 20;
        //    arrayInteiros[2] = int.Parse("30"); // tranformando a string em numero
           
        //    System.Console.WriteLine("Percorrendo o Array pelo For!");
        //    for( int i = 0; i < arrayInteiros.Length; i++)
        //    {
        //          Console.WriteLine(arrayInteiros[i]);
        //    }
        //    System.Console.WriteLine("Percorrendo o Array pelo Foreach!");
        //    foreach(int iten in arrayInteiros)
        //    {
        //        Console.WriteLine(iten);
        //    }


              
        }
    }
}
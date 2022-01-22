using System;

namespace CRUD;

class Program{

    static SerieRepositorio repositorio = new SerieRepositorio();

    public static void Main(string[] args)
    {
      string opcaoUsuario = ObterOpcaoDoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
           switch(opcaoUsuario)
           {
             case "1":
                 ListarSeries();
                 break;
             case "2":
                 InserirSerie();
                 break;
             case "3":
                 AtualizarSerie();
                 break;
             case "4":
                 ExcluirSerie();
                 break;
             case "5":
                 VisualizarSerie();
                 break;
             case "C":
                 Console.Clear();
                 break; 

              default:
                  throw new ArgumentOutOfRangeException();                  
           }

           opcaoUsuario = ObterOpcaoDoUsuario();
      }

      Console.WriteLine("Obrigado po Utilizar nossos serviços.");
      Console.ReadLine();    

    } 
     private static string ObterOpcaoDoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("Repositorios de Series!");
      Console.WriteLine("Informe a opção Desejada!");

      Console.WriteLine("1 - Listar Séries");
      Console.WriteLine("2 - Inserir nova Série");
      Console.WriteLine("3 - Atualizar Série");
      Console.WriteLine("4 - Excluir Série");
      Console.WriteLine("5 - Visualizar Séries");
      Console.WriteLine("C - Limpar Tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return opcaoUsuario;      
    }

    // METODOS DO switch

    private static void ListarSeries()
    {
      Console.WriteLine("Listar Series");

      var lista = repositorio.Lista();
      if(lista.Count == 0)
      {
        Console.WriteLine("Nenhuma Serie cadastrada.");
        return;
      }
      foreach(var serie in lista)
      {
        var excluido = serie.retornaExcluido();
        Console.WriteLine("#ID {0}: -  {1}  {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
      }
    }

    private static void InserirSerie()
    {
      Console.WriteLine("Inserir nova Serie");

      foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
      }
        Console.Write("Digite o genero entre as opções acima:  ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o Titulo da Serie: ");
        string entradaTitulo =(Console.ReadLine());

        Console.Write("Digite o Ano da Serie: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite o Titulo da Serie: ");
        string entradaDescricao = (Console.ReadLine());

        Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    ano: entradaAno,
                                    descricao: entradaDescricao);

        repositorio.Insere(novaSerie);                            
    }

    private static void AtualizarSerie()
    {
      Console.WriteLine("Digite o Id da Serie");
      int indiceSerie = int.Parse(Console.ReadLine());

      foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
      }
        Console.Write("Digite o genero entre as opções acima:  ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o Titulo da Serie: ");
        string entradaTitulo =(Console.ReadLine());

        Console.Write("Digite o Ano da Serie: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite o Titulo da Serie: ");
        string entradaDescricao = (Console.ReadLine());

        Serie atualizarSerie = new Serie(id: indiceSerie,
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    ano: entradaAno,
                                    descricao: entradaDescricao);

        repositorio.Atualizar(indiceSerie, atualizarSerie);                       

    }

    private static void ExcluirSerie()
    {
      
      Console.Write("Digite o id da Série: ");
      int indiceSerie = int.Parse(Console.ReadLine());

      repositorio.Exclui(indiceSerie);
    }

    private static void VisualizarSerie()
    {
      Console.Write("Digite o id da Serie: ");
      int indiceSerie = int.Parse(Console.ReadLine());

      var serie = repositorio.RetornaPorId(indiceSerie);
      Console.WriteLine(serie);
    }   

}
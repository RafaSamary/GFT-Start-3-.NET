using System;

namespace Excecoes;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 100, b = 0;
        double resultado = 0;

        try
        {
             resultado = Dividir(a, b);
        Console.WriteLine("{0} dividido por {1} = {2}", a, b, resultado);
        }
        catch(Exception ex)
        {
          Console.WriteLine(ex.Message);   
        }
        finally
        {
             Console.WriteLine("Finalmente a divisão foi realizada!");
        }       
    
    }
    static double  Dividir(int x, int y)
    {
        if( y == 0)
        {
            throw new MyClassException("Erro na Divisão por zero");
        }
        return (x / y);
    }
}
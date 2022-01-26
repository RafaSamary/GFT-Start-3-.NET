using System.Text;


namespace TrabalahndoComStreams
{
    class Program
    {

        public static void Main(string[] args)
        {
            
            var escrever = new StringBuilder();
            escrever.AppendLine("Caracteres na primeira linha para ler");
            escrever.AppendLine("e a segunda linha");
            escrever.AppendLine("e o fim");

            using var lendo = new  StringReader(escrever.ToString());
            //var buffer = new char[10];
            //var tamanho = 0;
            do{
                  System.Console.WriteLine(lendo.ReadLine()); // LER POR PARAGRAFO
            }
            while(lendo.Peek() >= 0);

            // do
            // {
            //     buffer = new char[10];
            //     tamanho = lendo.Read(buffer);
            //     System.Console.Write(string.Join("",buffer));     // LER POR BUFFER ESPECIFICADO
            // }
            // while(tamanho >= buffer.Length);

            System.Console.WriteLine("Digite ENTER para finalizar");
            Console.ReadLine();

           
























       

        }
    }
}

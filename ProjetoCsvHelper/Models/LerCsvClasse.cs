using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

namespace ProjetoCsvHelper.Models
{
    public class LerCsvClasse
    {
        public void lerClasse()
        {
            var caminho = Path.Combine(Environment.CurrentDirectory, "Entrada", "cadastro.csv");
            var arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)

                throw new FileNotFoundException($"O arquivo {caminho} não existe!");

            using var lendo = new StreamReader(arquivo.FullName);
                  var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
            using var csvReader = new CsvReader(lendo, csvConfig);

            var registros = csvReader.GetRecords<Usuario>();

            foreach (var registro in registros)
            {
                Console.WriteLine($"Nome:{registro.Nome}");
                Console.WriteLine($"Email:{registro.Email}");
                Console.WriteLine($"Telefone:{registro.Telefone}");
                Console.WriteLine($"Nacimento:{registro.Nascimento}");
                Console.WriteLine($"--------------");
            }

        }
    }
}
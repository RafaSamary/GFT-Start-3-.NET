using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

namespace ProjetoCsvHelper
{
    public class LerCsvDynamic
    {
        public void LerDynamic()
        {
            var caminho = Path.Combine(Environment.CurrentDirectory, "Entrada", "cadastro.csv");
            var arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)

                throw new FileNotFoundException($"O arquivo {caminho} não existe!");

            using var lendo = new StreamReader(arquivo.FullName);
                  var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
            using var csvReader = new CsvReader(lendo, csvConfig);

            var registros = csvReader.GetRecords<dynamic>();

            foreach (var registro in registros)
            {
                Console.WriteLine($"Nome:{registro.nome}");
                Console.WriteLine($"Email:{registro.email}");
                Console.WriteLine($"Telefone:{registro.telefone}");
                Console.WriteLine($"Nacimento:{registro.nascimento}");
                Console.WriteLine($"--------------");
            }

        }
    }
}
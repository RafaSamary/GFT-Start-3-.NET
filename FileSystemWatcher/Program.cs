

var path = @"C:\workspace\BootCampGFT\GFT-Start-3-.NET\Diretórios\globo";
using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

System.Console.WriteLine($"Monitorando eventos na Pasta: {path}");

System.Console.WriteLine("Pressione ENTER para finalizar:");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
   System.Console.WriteLine( $"Foi criado o arquivo:{e.Name}");
}



void OnDeleted(object sender, FileSystemEventArgs e)
{
    System.Console.WriteLine( $"Foi excluido o arquivo:{e.Name}");
}



void OnRenamed(object sender, RenamedEventArgs e)
{
    System.Console.WriteLine( $"O arquivo: {e.OldName}, foi renomeado para: {e.Name}");
}
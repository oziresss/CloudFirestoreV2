public class Program
{
    private static async Task Main(string[] args)
    {
        var cloudFirestore = new CloudFirestoreV2.CloudFirestore();

        var dataInicio = DateTime.Now;

        await cloudFirestore.BuscarDados();

        var dataFim = DateTime.Now;

        Console.WriteLine($"TEMPO DE EXECUÇÃO {dataFim.Minute - dataInicio.Minute} MINUTOS.");
    }
}
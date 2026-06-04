using SpaceMonitor.Models;

namespace SpaceMonitor.Reports;

public partial class Relatorio
{
    public void ExibirCabecalho()
    {
        Console.WriteLine(Titulo);
        Console.WriteLine($"Gerado em: {DataGeracao:dd/MM/yyyy HH:mm:ss}");
        Console.WriteLine(new string('-', 80));
    }

    public void AdicionarLinhaObjeto(ObjetoEspacial objetoEspacial)
    {
        Console.WriteLine($"{objetoEspacial.GetType().Name} | {objetoEspacial.Nome} | Altitude: {objetoEspacial.Altitude:F2} km | Velocidade: {objetoEspacial.Velocidade:F2} km/h | Coordenada: {objetoEspacial.Coordenada}");
    }

    public void ExibirResumo()
    {
        Console.WriteLine(new string('-', 80));
        Console.WriteLine($"Total de objetos monitorados: {TotalObjetos}");
    }
}

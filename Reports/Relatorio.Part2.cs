using SpaceMonitor.Models;

namespace SpaceMonitor.Reports;

public partial class Relatorio
{
    /// <summary>
    /// Exibe o cabeçalho do relatório.
    /// </summary>
    public void ExibirCabecalho()
    {
        Console.WriteLine(Titulo);
        Console.WriteLine($"Gerado em: {DataGeracao:dd/MM/yyyy HH:mm:ss}");
        Console.WriteLine(new string('-', 80));
    }

    /// <summary>
    /// Exibe uma linha de detalhe para um objeto espacial.
    /// </summary>
    public void AdicionarLinhaObjeto(ObjetoEspacial objetoEspacial)
    {
        Console.WriteLine($"{objetoEspacial.GetType().Name} | {objetoEspacial.Nome} | Altitude: {objetoEspacial.Altitude:F2} km | Velocidade: {objetoEspacial.Velocidade:F2} km/h | Coordenada: {objetoEspacial.Coordenada}");
    }

    /// <summary>
    /// Exibe o resumo final do relatório.
    /// </summary>
    public void ExibirResumo()
    {
        Console.WriteLine(new string('-', 80));
        Console.WriteLine($"Total de objetos monitorados: {TotalObjetos}");
    }
}

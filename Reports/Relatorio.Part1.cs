namespace SpaceMonitor.Reports;

/// <summary>
/// Representa um relatório consolidado da central de monitoramento espacial.
/// </summary>
public partial class Relatorio
{
    public Relatorio(string titulo, DateTime dataGeracao, int totalObjetos)
    {
        Titulo = titulo;
        DataGeracao = dataGeracao;
        TotalObjetos = totalObjetos;
    }

    public string Titulo { get; }

    public DateTime DataGeracao { get; }

    public int TotalObjetos { get; }
}

namespace SpaceMonitor.Reports;

/// <summary>
/// Representa um relatório consolidado da central de monitoramento espacial.
/// </summary>
public partial class Relatorio
{
    /// <summary>
    /// Inicializa um relatório.
    /// </summary>
    public Relatorio(string titulo, DateTime dataGeracao, int totalObjetos)
    {
        Titulo = titulo;
        DataGeracao = dataGeracao;
        TotalObjetos = totalObjetos;
    }

    /// <summary>
    /// Título do relatório.
    /// </summary>
    public string Titulo { get; }

    /// <summary>
    /// Data e hora de geração do relatório.
    /// </summary>
    public DateTime DataGeracao { get; }

    /// <summary>
    /// Total de objetos considerados no relatório.
    /// </summary>
    public int TotalObjetos { get; }
}

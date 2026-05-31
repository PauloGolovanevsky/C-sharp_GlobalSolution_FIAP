namespace SpaceMonitor.Data;

/// <summary>
/// Mantém o histórico cronológico de eventos emitidos pela central de monitoramento.
/// </summary>
public sealed class HistoricoEventos
{
    private readonly List<string> _eventos = [];

    /// <summary>
    /// Registra um evento com data e hora atuais.
    /// </summary>
    public void RegistrarEvento(string descricao)
    {
        _eventos.Add($"{DateTime.Now:dd/MM/yyyy HH:mm:ss} - {descricao}");
    }

    /// <summary>
    /// Exibe todos os eventos registrados.
    /// </summary>
    public void ExibirHistorico()
    {
        if (_eventos.Count == 0)
        {
            Console.WriteLine("Nenhum evento registrado.");
            return;
        }

        Console.WriteLine("Histórico de Eventos:");
        foreach (string evento in _eventos)
        {
            Console.WriteLine(evento);
        }
    }

    /// <summary>
    /// Retorna uma cópia somente leitura dos eventos registrados.
    /// </summary>
    public IReadOnlyCollection<string> ObterEventos()
    {
        return _eventos.AsReadOnly();
    }
}

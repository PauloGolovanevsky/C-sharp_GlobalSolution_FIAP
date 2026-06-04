namespace SpaceMonitor.Data;

/// <summary>
/// Mantém o histórico cronológico de eventos emitidos pela central de monitoramento.
/// </summary>
public sealed class HistoricoEventos
{
    private readonly List<string> _eventos = [];

    public void RegistrarEvento(string descricao)
    {
        _eventos.Add($"{DateTime.Now:dd/MM/yyyy HH:mm:ss} - {descricao}");
    }

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

    public IReadOnlyCollection<string> ObterEventos()
    {
        return _eventos.AsReadOnly();
    }
}

using SpaceMonitor.Data;
using SpaceMonitor.Models;

namespace SpaceMonitor.Services;

/// <summary>
/// Serviço responsável por emitir alertas preventivos de risco orbital.
/// </summary>
public sealed class AlertaService
{
    private readonly HistoricoEventos _historicoEventos;

    /// <summary>
    /// Inicializa o serviço de alertas.
    /// </summary>
    public AlertaService(HistoricoEventos historicoEventos)
    {
        _historicoEventos = historicoEventos;
    }

    /// <summary>
    /// Emite um alerta de risco de colisão entre dois objetos.
    /// </summary>
    public void EmitirAlertaColisao(ObjetoEspacial primeiroObjeto, ObjetoEspacial segundoObjeto, double diferencaAltitude)
    {
        string mensagem = $"Alerta de colisão: {primeiroObjeto.Nome} e {segundoObjeto.Nome} estão com diferença de altitude de {diferencaAltitude:F2} km.";
        Console.WriteLine(mensagem);
        _historicoEventos.RegistrarEvento(mensagem);
    }
}

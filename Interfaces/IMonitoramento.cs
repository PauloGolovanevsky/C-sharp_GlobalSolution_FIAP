namespace SpaceMonitor.Interfaces;

/// <summary>
/// Define operações de monitoramento orbital para objetos espaciais.
/// </summary>
public interface IMonitoramento
{
    /// <summary>
    /// Lista os objetos monitorados.
    /// </summary>
    void MonitorarObjetos();

    /// <summary>
    /// Verifica riscos de colisão entre objetos monitorados.
    /// </summary>
    void VerificarRiscoColisao();
}

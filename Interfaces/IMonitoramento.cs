namespace SpaceMonitor.Interfaces;

/// <summary>
/// Define operações de monitoramento orbital para objetos espaciais.
/// </summary>
public interface IMonitoramento
{
    void MonitorarObjetos();

    void VerificarRiscoColisao();
}

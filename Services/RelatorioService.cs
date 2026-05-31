using SpaceMonitor.Data;
using SpaceMonitor.Models;
using SpaceMonitor.Reports;

namespace SpaceMonitor.Services;

/// <summary>
/// Serviço responsável por gerar relatórios consolidados do monitoramento espacial.
/// </summary>
public sealed class RelatorioService
{
    private readonly MonitoramentoService _monitoramentoService;
    private readonly HistoricoEventos _historicoEventos;

    /// <summary>
    /// Inicializa o serviço de relatório.
    /// </summary>
    public RelatorioService(MonitoramentoService monitoramentoService, HistoricoEventos historicoEventos)
    {
        _monitoramentoService = monitoramentoService;
        _historicoEventos = historicoEventos;
    }

    /// <summary>
    /// Gera e exibe um relatório com os objetos monitorados.
    /// </summary>
    public void GerarRelatorio()
    {
        IReadOnlyCollection<ObjetoEspacial> objetos = _monitoramentoService.ObterObjetos();
        Relatorio relatorio = new("Relatório de Monitoramento Orbital", DateTime.Now, objetos.Count);

        relatorio.ExibirCabecalho();
        foreach (ObjetoEspacial objeto in objetos)
        {
            relatorio.AdicionarLinhaObjeto(objeto);
        }

        relatorio.ExibirResumo();
        _historicoEventos.RegistrarEvento($"Relatório gerado com {objetos.Count} objeto(s) monitorado(s).");
    }
}

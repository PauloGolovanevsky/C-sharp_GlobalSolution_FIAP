using SpaceMonitor.Data;
using SpaceMonitor.Exceptions;
using SpaceMonitor.Interfaces;
using SpaceMonitor.Models;

namespace SpaceMonitor.Services;

/// <summary>
/// Serviço principal de cadastro, consulta e monitoramento de objetos espaciais.
/// </summary>
public sealed class MonitoramentoService : IMonitoramento
{
    private const double LimiteRiscoColisaoKm = 50;
    private readonly List<ObjetoEspacial> _objetosEspaciais = [];
    private readonly AlertaService _alertaService;
    private readonly HistoricoEventos _historicoEventos;

    public MonitoramentoService(AlertaService alertaService, HistoricoEventos historicoEventos)
    {
        _alertaService = alertaService;
        _historicoEventos = historicoEventos;
    }

    /// <summary>
    /// Cadastra um objeto espacial no monitoramento.
    /// </summary>
    public void CadastrarObjeto(ObjetoEspacial objetoEspacial)
    {
        ValidarAltitude(objetoEspacial.Altitude);
        _objetosEspaciais.Add(objetoEspacial);
        _historicoEventos.RegistrarEvento($"Cadastro realizado: {objetoEspacial.Nome} ({objetoEspacial.GetType().Name}).");
    }

    public void MonitorarObjetos()
    {
        if (_objetosEspaciais.Count == 0)
        {
            throw new ObjetoNaoEncontradoException("Nenhum objeto espacial cadastrado para listagem.");
        }

        Console.WriteLine("Objetos Espaciais Monitorados:");
        foreach (ObjetoEspacial objeto in _objetosEspaciais)
        {
            objeto.ExibirInformacoes();
        }
    }

    public void VerificarRiscoColisao()
    {
        if (_objetosEspaciais.Count < 2)
        {
            throw new ObjetoNaoEncontradoException("São necessários pelo menos dois objetos cadastrados para simular risco de colisão.");
        }

        bool alertaEmitido = false;

        for (int i = 0; i < _objetosEspaciais.Count; i++)
        {
            for (int j = i + 1; j < _objetosEspaciais.Count; j++)
            {
                ObjetoEspacial primeiroObjeto = _objetosEspaciais[i];
                ObjetoEspacial segundoObjeto = _objetosEspaciais[j];
                double diferencaAltitude = Math.Abs(primeiroObjeto.Altitude - segundoObjeto.Altitude);

                if (diferencaAltitude < LimiteRiscoColisaoKm)
                {
                    _alertaService.EmitirAlertaColisao(primeiroObjeto, segundoObjeto, diferencaAltitude);
                    alertaEmitido = true;
                }
            }
        }

        if (!alertaEmitido)
        {
            Console.WriteLine("Nenhum risco de colisão identificado no limite configurado.");
            _historicoEventos.RegistrarEvento("Simulação concluída sem risco de colisão identificado.");
        }
    }

    public IReadOnlyCollection<ObjetoEspacial> ObterObjetos()
    {
        return _objetosEspaciais.AsReadOnly();
    }

    private static void ValidarAltitude(double altitude)
    {
        if (altitude <= 0)
        {
            throw new AltitudeInvalidaException("A altitude deve ser maior que zero.");
        }
    }
}

using SpaceMonitor.Structs;

namespace SpaceMonitor.Models;

/// <summary>
/// Representa um satélite artificial em órbita terrestre.
/// </summary>
public sealed class Satelite : ObjetoEspacial
{
    /// <summary>
    /// Inicializa um novo satélite monitorado.
    /// </summary>
    public Satelite(
        string nome,
        double altitude,
        double velocidade,
        CoordenadaOrbital coordenada,
        string agenciaResponsavel)
        : base(Guid.NewGuid(), nome, altitude, velocidade, coordenada)
    {
        AgenciaResponsavel = agenciaResponsavel;
    }

    /// <summary>
    /// Agência ou organização responsável pelo satélite.
    /// </summary>
    public string AgenciaResponsavel { get; }

    /// <inheritdoc />
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Satélite] {Nome} | Id: {Id} | Altitude: {Altitude:F2} km | Velocidade: {Velocidade:F2} km/h | Coordenada: {Coordenada} | Agência: {AgenciaResponsavel} | Registro: {DataRegistro:dd/MM/yyyy HH:mm:ss}");
    }
}

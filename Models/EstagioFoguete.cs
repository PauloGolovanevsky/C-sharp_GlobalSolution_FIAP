using SpaceMonitor.Structs;

namespace SpaceMonitor.Models;

/// <summary>
/// Representa um estágio de foguete remanescente em órbita.
/// </summary>
public sealed class EstagioFoguete : ObjetoEspacial
{
    /// <summary>
    /// Inicializa um novo estágio de foguete monitorado.
    /// </summary>
    public EstagioFoguete(
        string nome,
        double altitude,
        double velocidade,
        CoordenadaOrbital coordenada,
        string missaoOrigem)
        : base(Guid.NewGuid(), nome, altitude, velocidade, coordenada)
    {
        MissaoOrigem = missaoOrigem;
    }

    /// <summary>
    /// Missão associada ao lançamento do estágio.
    /// </summary>
    public string MissaoOrigem { get; }

    /// <inheritdoc />
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Estágio de Foguete] {Nome} | Id: {Id} | Altitude: {Altitude:F2} km | Velocidade: {Velocidade:F2} km/h | Coordenada: {Coordenada} | Missão: {MissaoOrigem} | Registro: {DataRegistro:dd/MM/yyyy HH:mm:ss}");
    }
}

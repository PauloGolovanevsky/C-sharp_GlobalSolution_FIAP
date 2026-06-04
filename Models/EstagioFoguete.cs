using SpaceMonitor.Structs;

namespace SpaceMonitor.Models;

/// <summary>
/// Representa um estágio de foguete remanescente em órbita.
/// </summary>
public sealed class EstagioFoguete : ObjetoEspacial
{
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

    public string MissaoOrigem { get; }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Estágio de Foguete] {Nome} | Id: {Id} | Altitude: {Altitude:F2} km | Velocidade: {Velocidade:F2} km/h | Coordenada: {Coordenada} | Missão: {MissaoOrigem} | Registro: {DataRegistro:dd/MM/yyyy HH:mm:ss}");
    }
}

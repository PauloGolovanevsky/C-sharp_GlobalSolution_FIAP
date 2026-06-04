using SpaceMonitor.Structs;

namespace SpaceMonitor.Models;

/// <summary>
/// Representa um fragmento ou resíduo de objeto espacial em órbita.
/// </summary>
public sealed class DetritoEspacial : ObjetoEspacial
{
    public DetritoEspacial(
        string nome,
        double altitude,
        double velocidade,
        CoordenadaOrbital coordenada,
        string origemProvavel)
        : base(Guid.NewGuid(), nome, altitude, velocidade, coordenada)
    {
        OrigemProvavel = origemProvavel;
    }

    public string OrigemProvavel { get; }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Detrito Espacial] {Nome} | Id: {Id} | Altitude: {Altitude:F2} km | Velocidade: {Velocidade:F2} km/h | Coordenada: {Coordenada} | Origem: {OrigemProvavel} | Registro: {DataRegistro:dd/MM/yyyy HH:mm:ss}");
    }
}

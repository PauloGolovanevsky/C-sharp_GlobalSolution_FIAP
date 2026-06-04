using SpaceMonitor.Structs;

namespace SpaceMonitor.Models;

/// <summary>
/// Classe base abstrata para qualquer objeto monitorado em órbita terrestre.
/// </summary>
public abstract class ObjetoEspacial
{
    protected ObjetoEspacial(
        Guid id,
        string nome,
        double altitude,
        double velocidade,
        CoordenadaOrbital coordenada)
    {
        Id = id;
        Nome = nome;
        Altitude = altitude;
        Velocidade = velocidade;
        Coordenada = coordenada;
        DataRegistro = DateTime.Now;
    }

    public Guid Id { get; }

    public string Nome { get; private set; }

    public double Altitude { get; private set; }

    public double Velocidade { get; private set; }

    public DateTime DataRegistro { get; }

    public CoordenadaOrbital Coordenada { get; private set; }

    /// <summary>
    /// Exibe as informações específicas do objeto espacial.
    /// </summary>
    public abstract void ExibirInformacoes();

    public void AtualizarAltitude(double altitude)
    {
        Altitude = altitude;
    }
}

using SpaceMonitor.Structs;

namespace SpaceMonitor.Models;

/// <summary>
/// Classe base abstrata para qualquer objeto monitorado em órbita terrestre.
/// </summary>
public abstract class ObjetoEspacial
{
    /// <summary>
    /// Inicializa dados comuns de um objeto espacial.
    /// </summary>
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

    /// <summary>
    /// Identificador único do objeto espacial.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Nome de referência do objeto espacial.
    /// </summary>
    public string Nome { get; private set; }

    /// <summary>
    /// Altitude orbital em quilômetros.
    /// </summary>
    public double Altitude { get; private set; }

    /// <summary>
    /// Velocidade orbital em quilômetros por hora.
    /// </summary>
    public double Velocidade { get; private set; }

    /// <summary>
    /// Data e hora em que o objeto foi registrado no sistema.
    /// </summary>
    public DateTime DataRegistro { get; }

    /// <summary>
    /// Coordenada orbital simplificada do objeto espacial.
    /// </summary>
    public CoordenadaOrbital Coordenada { get; private set; }

    /// <summary>
    /// Exibe as informações específicas do objeto espacial.
    /// </summary>
    public abstract void ExibirInformacoes();

    /// <summary>
    /// Atualiza a altitude orbital do objeto.
    /// </summary>
    public void AtualizarAltitude(double altitude)
    {
        Altitude = altitude;
    }
}

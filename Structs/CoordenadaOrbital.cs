namespace SpaceMonitor.Structs;

/// <summary>
/// Representa uma coordenada orbital simplificada usada para localizar objetos em órbita.
/// </summary>
public readonly struct CoordenadaOrbital
{
    /// <summary>
    /// Inicializa uma nova coordenada orbital.
    /// </summary>
    /// <param name="latitude">Latitude orbital em graus.</param>
    /// <param name="longitude">Longitude orbital em graus.</param>
    public CoordenadaOrbital(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    /// <summary>
    /// Latitude orbital em graus.
    /// </summary>
    public double Latitude { get; }

    /// <summary>
    /// Longitude orbital em graus.
    /// </summary>
    public double Longitude { get; }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"Lat: {Latitude:F2}, Long: {Longitude:F2}";
    }
}

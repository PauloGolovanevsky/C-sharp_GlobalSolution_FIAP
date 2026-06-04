namespace SpaceMonitor.Structs;

/// <summary>
/// Representa uma coordenada orbital simplificada usada para localizar objetos em órbita.
/// </summary>
public readonly struct CoordenadaOrbital
{
    public CoordenadaOrbital(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double Latitude { get; }

    public double Longitude { get; }

    public override string ToString()
    {
        return $"Lat: {Latitude:F2}, Long: {Longitude:F2}";
    }
}

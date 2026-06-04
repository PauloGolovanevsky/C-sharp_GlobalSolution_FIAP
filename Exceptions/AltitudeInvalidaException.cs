namespace SpaceMonitor.Exceptions;

/// <summary>
/// Exceção lançada quando uma altitude orbital inválida é informada.
/// </summary>
public sealed class AltitudeInvalidaException : Exception
{
    public AltitudeInvalidaException(string message)
        : base(message)
    {
    }
}

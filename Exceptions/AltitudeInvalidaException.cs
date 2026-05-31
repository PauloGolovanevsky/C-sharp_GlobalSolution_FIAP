namespace SpaceMonitor.Exceptions;

/// <summary>
/// Exceção lançada quando uma altitude orbital inválida é informada.
/// </summary>
public sealed class AltitudeInvalidaException : Exception
{
    /// <summary>
    /// Inicializa uma nova instância da exceção.
    /// </summary>
    public AltitudeInvalidaException(string message)
        : base(message)
    {
    }
}

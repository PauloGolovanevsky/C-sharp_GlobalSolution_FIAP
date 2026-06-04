namespace SpaceMonitor.Exceptions;

/// <summary>
/// Exceção lançada quando um objeto espacial não é localizado no monitoramento.
/// </summary>
public sealed class ObjetoNaoEncontradoException : Exception
{
    public ObjetoNaoEncontradoException(string message)
        : base(message)
    {
    }
}

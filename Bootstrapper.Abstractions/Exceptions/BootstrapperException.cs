namespace Ksh.Bootstrapper.Abstractions.Exceptions;

[ExcludeFromCodeCoverage] public class BootstrapperException : Exception
{
    public BootstrapperException()
    {
    }

    public BootstrapperException(string message) : base(message)
    {
    }

    public BootstrapperException(string message, Exception inner) : base(message, inner)
    {
    }
}
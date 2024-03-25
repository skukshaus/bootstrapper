namespace Ksh.Bootstrapper.Abstractions;

public interface IBootstrapper
{
    void ActivateAll();
    void DeactivateAll();
}
namespace Ksh.Bootstrapper;

public class StandardBootstrapper(IEnumerable<IActivatable>? activators, IEnumerable<IDeactivatable>? deactivators)
    : IBootstrapper
{
    private bool _isActivated;
    private bool _isDeactivated;

    public void ActivateAll()
    {
        if (_isActivated)
        {
            return;
        }

        foreach (var activator in activators ?? [])
        {
            activator.Activate();
        }

        _isActivated = true;
    }

    public void DeactivateAll()
    {
        if (_isDeactivated)
            return;

        foreach (var deactivator in deactivators ?? [])
        {
            deactivator.Deactivate();
        }

        _isDeactivated = true;
    }
}
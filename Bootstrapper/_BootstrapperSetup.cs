namespace Ksh.Bootstrapper;

public class BootstrapperSetup
{
}

[ExcludeFromCodeCoverage]
public static class _BootstrapperModule
{
    public static IServiceCollection AddBootstrapperModule(this IServiceCollection services)
        => services.AddSingleton<IBootstrapper, StandardBootstrapper>();
}
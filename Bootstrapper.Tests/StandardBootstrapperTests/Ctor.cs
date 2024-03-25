namespace Ksh.Bootstrapper.Tests.StandardBootstrapperTests;

public partial class StandardBootstrapperTest
{
    [Fact] public void NullParametersMustNotCrash()
    {
        var sut = new StandardBootstrapper(null!, null!);

        sut.Invoking(x => x.ActivateAll())
            .Should().NotThrow();
    }
}
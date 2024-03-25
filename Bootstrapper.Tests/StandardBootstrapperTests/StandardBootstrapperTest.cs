namespace Ksh.Bootstrapper.Tests.StandardBootstrapperTests;

public class StandardBootstrapperTest : IDisposable
{
    private StandardBootstrapper _systemUnderTest;

    public StandardBootstrapperTest()
    {
        _systemUnderTest = new();
    }

    [Fact] public void AfterInitialisationInstanceIsNotNull()
    {
        // Arrange

        // Act

        // Assert
        using var _ = new AssertionScope();

        _systemUnderTest.Should().NotBeNull();
    }

    ~StandardBootstrapperTest()
    {
        ReleaseUnmanagedResources();
    }

    private void ReleaseUnmanagedResources()
    {
        // TODO release managed resources here
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }
}
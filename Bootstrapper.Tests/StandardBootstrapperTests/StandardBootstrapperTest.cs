namespace Ksh.Bootstrapper.Tests.StandardBootstrapperTests;

public partial class StandardBootstrapperTest
{
    private StandardBootstrapper _systemUnderTest;

    private Mock<IActivatable> _activator1Mock= new();
    private Mock<IActivatable> _activator2Mock= new();

    private Mock<IDeactivatable> _deactivator1Mock= new();
    private Mock<IDeactivatable> _deactivator2Mock = new();
    
    public StandardBootstrapperTest()
    {
        var activators = new List<IActivatable>
        {
            _activator1Mock.Object,
            _activator2Mock.Object
        };

        var deactivators = new List<IDeactivatable>
        {
            _deactivator1Mock.Object,
            _deactivator2Mock.Object
        };

        _systemUnderTest = new(activators, deactivators);
    }

    [Fact] public void AfterInitialisationInstanceIsNotNull()
    {
        // Arrange

        // Act

        // Assert
        using var _ = new AssertionScope();

        _systemUnderTest.Should().NotBeNull();
    }
}
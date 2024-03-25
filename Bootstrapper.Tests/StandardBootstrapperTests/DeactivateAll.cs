namespace Ksh.Bootstrapper.Tests.StandardBootstrapperTests;

public partial class StandardBootstrapperTest
{
    [Fact] public void DeactivateMethodMustBeCalledDuringDeactivating()
    {
        _systemUnderTest.DeactivateAll();

        _deactivator1Mock.Verify(x => x.Deactivate(), Times.Once());
        _deactivator2Mock.Verify(x => x.Deactivate(), Times.Once());
    }

    [Fact] public void DeactivateMethodMustNotBeCalledTwice()
    {
        _systemUnderTest.DeactivateAll();

        _systemUnderTest.DeactivateAll();

        _deactivator1Mock.Verify(x => x.Deactivate(), Times.Once());
        _deactivator2Mock.Verify(x => x.Deactivate(), Times.Once());
    }
}
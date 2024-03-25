namespace Ksh.Bootstrapper.Tests.StandardBootstrapperTests;

public partial class StandardBootstrapperTest
{
    [Fact] public void ActivateMethodMustBeCalledDuringActivating()
    {
        _systemUnderTest.ActivateAll();

        _activator1Mock.Verify(x => x.Activate(), Times.Once());
        _activator2Mock.Verify(x => x.Activate(), Times.Once());
    }

    [Fact] public void ActivateMethodMustNotBeCalledTwice()
    {
        _systemUnderTest.ActivateAll();

        _systemUnderTest.ActivateAll();

        _activator1Mock.Verify(x => x.Activate(), Times.Once());
        _activator2Mock.Verify(x => x.Activate(), Times.Once());
    }
}
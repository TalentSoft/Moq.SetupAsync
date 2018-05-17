using System;
using System.Threading.Tasks;
using Xunit;

namespace Moq.SetupAsync.Tests
{
    public class CallbackAsyncFixture
    {
        [Fact]
        public void SetupAsyncActionIsWaitable()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.DoActionAsync());
            mock.Object.DoActionAsync().Wait();

            mock.VerifyAll();
        }

        [Fact]
        public void SetupAsyncActionWithOneArgIsWaitable()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.DoActionAsync(It.IsAny<string>()));
            mock.Object.DoActionAsync("any string").Wait();

            mock.VerifyAll();
        }

        [Fact]
        public void SetupAsyncActionIsVerifiable()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.DoActionAsync()).Verifiable();
            mock.Verify(x => x.DoActionAsync(), Times.Never);

            mock.Object.DoActionAsync().Wait();

            mock.Verify(x => x.DoActionAsync(), Times.Once);
            mock.Verify();
        }

        [Fact]
        public void SetupAsyncActionWithOneArgIsVerifiable()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.DoActionAsync(It.IsAny<string>())).Verifiable();
            mock.Verify(x => x.DoActionAsync("any string"), Times.Never);

            mock.Object.DoActionAsync("any string").Wait();

            mock.Verify(x => x.DoActionAsync("any string"), Times.Once);
            mock.Verify();
        }

        [Fact]
        public void SetupAsyncActionIsVerifiableAndErrorMessageCanBeSpecified()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.DoActionAsync()).Verifiable("custom fail message");

            var exception = Assert.Throws<MockException>(() => mock.Verify());
            Assert.Contains("custom fail message", exception.Message);
        }

        [Fact]
        public void SetupAsyncActionWithCallback()
        {
            var mock = new Mock<IFoo>();
            var isCalled = false;

            mock.SetupAsync(x => x.DoActionAsync()).Callback(() => isCalled = true);
            mock.Object.DoActionAsync().Wait();

            Assert.True(isCalled);
        }

        [Fact]
        public void SetupAsyncActionWithOneArgWithCallback()
        {
            var mock = new Mock<IFoo>();
            var isCalled = false;

            mock.SetupAsync(x => x.DoActionAsync(It.IsAny<string>())).Callback<string>(s => isCalled = s == "any string");
            mock.Object.DoActionAsync("any string").Wait();

            Assert.True(isCalled);
        }

        public interface IFoo
        {
            Task DoActionAsync();
            Task DoActionAsync(string arg1);
        }
    }
}

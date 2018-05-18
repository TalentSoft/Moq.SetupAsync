using System;
using System.Threading.Tasks;
using Xunit;

namespace Moq.SetupAsync.Tests
{
    public class SetupAsyncFuncFixture
    {
        [Fact]
        public void SetupAsyncFuncIsWaitable()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync());
            mock.Object.ExecFuncAsync().Wait();

            mock.VerifyAll();
        }

        [Fact]
        public void SetupAsyncFuncWithOneArgIsWaitable()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync(It.IsAny<string>()));
            mock.Object.ExecFuncAsync("any string").Wait();

            mock.VerifyAll();
        }

        [Fact]
        public void SetupAsyncFuncIsVerifiable()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync()).Verifiable();
            mock.Verify(x => x.ExecFuncAsync(), Times.Never);

            mock.Object.ExecFuncAsync().Wait();

            mock.Verify(x => x.ExecFuncAsync(), Times.Once);
            mock.Verify();
        }

        [Fact]
        public void SetupAsyncFuncWithOneArgIsVerifiable()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync(It.IsAny<string>())).Verifiable();
            mock.Verify(x => x.ExecFuncAsync("any string"), Times.Never);

            mock.Object.ExecFuncAsync("any string").Wait();

            mock.Verify(x => x.ExecFuncAsync("any string"), Times.Once);
            mock.Verify();
        }

        [Fact]
        public void SetupAsyncFuncIsVerifiableAndErrorMessageCanBeSpecified()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync()).Verifiable("custom fail message");

            var exception = Assert.Throws<MockException>(() => mock.Verify());
            Assert.Contains("custom fail message", exception.Message);
        }

        [Fact]
        public void SetupAsyncFuncReturnsNullByDefault()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync());

            Assert.Equal(null, mock.Object.ExecFuncAsync().Result);
        }

        [Fact]
        public void SetupAsyncFuncWithReturns()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync()).Returns("custom return");

            Assert.Equal("custom return", mock.Object.ExecFuncAsync().Result);
        }

        [Fact]
        public void SetupAsyncFuncWithOneArgWithReturns()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync(It.IsAny<string>())).Returns<string>(s => "hello " + s);

            var result = mock.Object.ExecFuncAsync("any string").Result;

            Assert.Equal("hello any string", result);
        }

        [Fact]
        public void SetupAsyncFuncWithThrows()
        {
            var mock = new Mock<IFoo>();

            mock.SetupAsync(x => x.ExecFuncAsync()).Throws<ArgumentException>();

            var task = mock.Object.ExecFuncAsync();

            Assert.ThrowsAsync<ArgumentException>(() => task).Wait();
        }

        public interface IFoo
        {
            Task<object> ExecFuncAsync();
            Task<object> ExecFuncAsync(string arg1);
        }
    }
}

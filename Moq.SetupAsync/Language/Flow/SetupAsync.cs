using System;
using System.Threading.Tasks;

namespace Moq.Language.Flow
{
    public class SetupAsync<TMock> : ISetupAsync
        where TMock : class
    {
        private ISetup<TMock, Task> Setup { get; }

        public SetupAsync(ISetup<TMock, Task> setup)
        {
            this.Setup = setup;
            this.Setup.Returns(TaskHelper.CompletedTask);
        }

        public IVerifies Callback(Action callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

        public IVerifies Callback<TArg1>(Action<TArg1> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

        public IVerifies Callback<TArg1, TArg2>(Action<TArg1, TArg2> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

        public IVerifies Callback<TArg1, TArg2, TArg3>(Action<TArg1, TArg2, TArg3> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4>(Action<TArg1, TArg2, TArg3, TArg4> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5>(Action<TArg1, TArg2, TArg3, TArg4, TArg5> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

        public IVerifies Throws(Exception exception)
        {
            return this.Setup.ThrowsAsync(exception);
        }

        public IVerifies Throws<TException>()
            where TException : Exception, new()
        {
            return this.Throws(new TException());
        }

        public void Verifiable()
        {
            this.Setup.Verifiable();
        }

        public void Verifiable(string failMessage)
        {
            this.Setup.Verifiable(failMessage);
        }
    }

    public class SetupAsync<TMock, TResult> : ISetupAsync<TResult>
        where TMock : class
    {
        private ISetup<TMock, Task<TResult>> Setup { get; }

        public SetupAsync(ISetup<TMock, Task<TResult>> setup)
        {
            this.Setup = setup;
            this.Setup.ReturnsAsync(default(TResult));
        }

        public IVerifies Returns(TResult value)
        {
            return this.Setup.ReturnsAsync(value);
        }

        public IVerifies Returns(Func<TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

        public IVerifies Returns<TArg>(Func<TArg, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

        public IVerifies Returns<TArg1, TArg2>(Func<TArg1, TArg2, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

        public IVerifies Returns<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4>(Func<TArg1, TArg2, TArg3, TArg4, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

        public IVerifies Throws(Exception exception)
        {
            return this.Setup.ThrowsAsync(exception);
        }

        public IVerifies Throws<TException>()
            where TException : Exception, new()
        {
            return this.Throws(new TException());
        }

        public void Verifiable()
        {
            this.Setup.Verifiable();
        }

        public void Verifiable(string failMessage)
        {
            this.Setup.Verifiable(failMessage);
        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
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

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2>(Action<TArg1, TArg2> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3>(Action<TArg1, TArg2, TArg3> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4>(Action<TArg1, TArg2, TArg3, TArg4> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5>(Action<TArg1, TArg2, TArg3, TArg4, TArg5> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> callback)
        {
            return this.Setup.CallbackAsync(callback);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> callback)
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

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2>(Func<TArg1, TArg2, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4>(Func<TArg1, TArg2, TArg3, TArg4, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> valueFunction)
        {
            return this.Setup.ReturnsAsync(valueFunction);
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> valueFunction)
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

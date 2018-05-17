namespace Moq.Language
{
    using System;

    public interface IReturnAsync<in TResult>
    {
        IVerifies Returns(TResult value);

        IVerifies Returns(Func<TResult> value);

        IVerifies Returns<TArg>(Func<TArg, TResult> valueFunction);

        IVerifies Returns<TArg1, TArg2>(Func<TArg1, TArg2, TResult> valueFunction);

        IVerifies Returns<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, TResult> valueFunction);

        IVerifies Returns<TArg1, TArg2, TArg3, TArg4>(Func<TArg1, TArg2, TArg3, TArg4, TResult> valueFunction);

        IVerifies Returns<TArg1, TArg2, TArg3, TArg4, TArg5>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> valueFunction);
    }
}
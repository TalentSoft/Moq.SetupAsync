namespace Moq.Language
{
    using System;

    public interface ICallbackAsync
    {
        IVerifies Callback(Action callback);

        IVerifies Callback<TArg1>(Action<TArg1> callback);

        IVerifies Callback<TArg1, TArg2>(Action<TArg1, TArg2> callback);

        IVerifies Callback<TArg1, TArg2, TArg3>(Action<TArg1, TArg2, TArg3> callback);

        IVerifies Callback<TArg1, TArg2, TArg3, TArg4>(Action<TArg1, TArg2, TArg3, TArg4> callback);

        IVerifies Callback<TArg1, TArg2, TArg3, TArg4, TArg5>(Action<TArg1, TArg2, TArg3, TArg4, TArg5> callback);
    }
}
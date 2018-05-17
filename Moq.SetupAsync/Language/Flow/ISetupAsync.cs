namespace Moq.Language.Flow
{
    public interface ISetupAsync : ICallbackAsync, IThrowsAsync, IVerifies
    {
    }

    public interface ISetupAsync<in TResult> : IReturnAsync<TResult>, IThrowsAsync, IVerifies
    {
    }
}

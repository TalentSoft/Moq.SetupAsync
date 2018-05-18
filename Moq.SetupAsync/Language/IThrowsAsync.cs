using System;

namespace Moq.Language
{
    public interface IThrowsAsync
    {
        /// <summary>
        /// Specifies the exception to throw when the async Task is invoked.
        /// </summary>
        /// <param name="exception">Exception instance to throw.</param>
        IVerifies Throws(Exception exception);

        /// <summary>
        /// Specifies the type of exception to throw when the Task is invoked.
        /// </summary>
        /// <typeparam name="TException">Type of exception to instantiate and throw when the setup is matched.</typeparam>
        IVerifies Throws<TException>()
            where TException : Exception, new();
    }
}

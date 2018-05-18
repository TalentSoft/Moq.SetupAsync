using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

using Moq.Language;
using Moq.Language.Flow;

namespace Moq
{
    /// <summary>
    /// Class that provide a simplified way to define a callback on an async mocked action.
    /// It's inspired from that discussion: https://stackoverflow.com/questions/21253523/setup-async-task-callback-in-moq-framework
    /// </summary>
    public static class CallbackAsyncExtensions
    {
        public static IReturnsResult<TMock> CallbackAsync<TMock>(
            this IReturns<TMock, Task> mock,
            Action callback)
            where TMock : class
        {
            return mock.Returns(
                () =>
                {
                    callback();
                    return TaskHelper.CompletedTask;
                });
        }

        public static IReturnsResult<TMock> CallbackAsync<T1, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1> callback)
            where TMock : class
        {
            return mock.Returns<T1>(
                t1 =>
                {
                    callback(t1);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2>(
                (t1, t2) =>
                {
                    callback(t1, t2);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3>(
                (t1, t2, t3) =>
                {
                    callback(t1, t2, t3);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4>(
                (t1, t2, t3, t4) =>
                {
                    callback(t1, t2, t3, t4);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5>(
                (t1, t2, t3, t4, t5) =>
                {
                    callback(t1, t2, t3, t4, t5);
                    return TaskHelper.CompletedTask;
                });
        }
    }
}
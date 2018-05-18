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

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6>(
                (t1, t2, t3, t4, t5, t6) =>
                {
                    callback(t1, t2, t3, t4, t5, t6);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7>(
                (t1, t2, t3, t4, t5, t6, t7) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8>(
                (t1, t2, t3, t4, t5, t6, t7, t8) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8, t9);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
                    return TaskHelper.CompletedTask;
                });
        }

#if !NETSTANDARD1_3 && DEBUG
        [ExcludeFromCodeCoverage]
#endif
        public static IReturnsResult<TMock> CallbackAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TMock>(
            this IReturns<TMock, Task> mock,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback)
            where TMock : class
        {
            return mock.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
                (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) =>
                {
                    callback(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
                    return TaskHelper.CompletedTask;
                });
        }
    }
}
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Moq.Language.Flow;

namespace Moq
{
    public static class SetupAsyncExtensions
    {
        public static ISetupAsync SetupAsync<TMock>(this Mock<TMock> mock, Expression<Func<TMock, Task>> expression)
            where TMock : class
        {
            return mock.Setup(expression).ToAsync();
        }

        public static ISetupAsync<TResult> SetupAsync<T, TResult>(this Mock<T> mock, Expression<Func<T, Task<TResult>>> expression)
            where T : class
        {
            return mock.Setup(expression).ToAsync();
        }

        public static ISetupAsync ToAsync<T>(this ISetup<T, Task> setup)
            where T : class
        {
            return new SetupAsync<T>(setup);
        }

        public static ISetupAsync<TResult> ToAsync<T, TResult>(this ISetup<T, Task<TResult>> setup)
            where T : class
        {
            return new SetupAsync<T, TResult>(setup);
        }
    }
}

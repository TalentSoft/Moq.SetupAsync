namespace Moq
{
    using System.Threading.Tasks;

    internal static class TaskHelper
    {
        public static Task CompletedTask
        {
            get
            {
#if NET45
                return new Task(() => { });
#else
                return Task.CompletedTask;
#endif
            }
        }
    }
}

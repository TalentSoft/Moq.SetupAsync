using System.Threading.Tasks;

namespace Moq
{
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

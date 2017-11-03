using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingExamples.Util
{
    class HostingEnvironment
    {
        public static void QueueBackgroundWorkItem(Func<CancellationToken, Task> func, CancellationToken ct)
        {
            func(ct);
        }
    }
}

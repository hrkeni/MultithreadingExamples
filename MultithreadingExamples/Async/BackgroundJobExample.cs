using MultithreadingExamples.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingExamples.Async
{
    class BackgroundJobExample
    {
        public void QueueWorkItem()
        {
            HostingEnvironment.QueueBackgroundWorkItem(LongRunningMethodAsync, new CancellationToken());
        }
        
        private async Task LongRunningMethodAsync(CancellationToken ct)
        {
            for(var i = 0; i < 1000; i++)
            {
                await Task.Delay(250);
                Console.WriteLine(i);
            }
        }
    }
}

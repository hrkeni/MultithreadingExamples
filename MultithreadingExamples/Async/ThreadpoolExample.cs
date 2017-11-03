using System;
using System.Threading.Tasks;

namespace MultithreadingExamples.Async
{
    class ThreadpoolExample
    {
        public async Task DoSomethingAsync()
        {
            var val = 10;

            // run on a thread pool thread
            await Task.Delay(500).ConfigureAwait(false);

            val *= 10;

            // run on a thread pool thread
            await Task.Delay(500).ConfigureAwait(false);

            Console.WriteLine(val);
        }
    }
}

using System;
using System.Threading.Tasks;

namespace MultithreadingExamples.Async
{
    class AsyncExample
    {
        public async Task DoSomethingAsync()
        {
            var val = 10;

            await Task.Delay(500);

            val *= 10;

            await Task.Delay(500);

            Console.WriteLine(val);
        }
    }
}

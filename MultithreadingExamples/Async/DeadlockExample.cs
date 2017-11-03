using System;
using System.Threading.Tasks;

namespace MultithreadingExamples.Async
{
    class DeadlockExample
    {
        public void Deadlock()
        {
            var task = Task.Run(WaitAsync);
            task.Wait();
        }

        async Task WaitAsync()
        {
            Console.WriteLine("Start");
            await Task.Delay(1000);
            Console.WriteLine("End");
        }
    }
}

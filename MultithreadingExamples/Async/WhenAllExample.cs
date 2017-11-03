using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingExamples.Async
{
    class WhenAllExample
    {

        public async Task DoSomething()
        {
            var task1 = GetResultAsync(500);
            var task2 = GetResultAsync(600);
            var task3 = GetResultAsync(700);

            Task[] tasks = { task1, task2, task3 };
            await Task.WhenAll(tasks);
        }

        private async Task<int> GetResultAsync(int wait)
        {
            await Task.Delay(wait);
            Console.WriteLine($"Waited {wait} ms");
            return wait;
        }
    }
}

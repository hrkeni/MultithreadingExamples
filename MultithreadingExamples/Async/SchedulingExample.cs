using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingExamples.Async
{
    class SchedulingExample
    {
        public void DoSomething()
        {
            var task = Task.Run<int>(async () =>
            {
                await Task.Delay(500);
                return 40;
            });

            Console.WriteLine($"Ran a task which returned {task.Result}");
        }
    }
}

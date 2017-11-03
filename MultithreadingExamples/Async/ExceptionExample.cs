using System;
using System.Threading.Tasks;

namespace MultithreadingExamples.Async
{
    class ExceptionExample
    {
        public async Task TrySomethingAsync()
        {
            try
            {
                await Task.Delay(1000);
                if (DateTime.Now.Millisecond % 2 == 0)
                {
                    throw new Exception("Error");
                }
                Console.WriteLine("Done!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

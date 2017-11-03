using MultithreadingExamples.Async;
using MultithreadingExamples.Util;
using System.Threading.Tasks;

namespace MultithreadingExamples
{
    class Program
    {
        async static Task Main(string[] args)
        {
            //await new AsyncExample().DoSomethingAsync();

            //await new ThreadpoolExample().DoSomethingAsync();

            //await new ExceptionExample().TrySomethingAsync();

            new DedicatedThreadSynchronisationContext().Send(_ => new DeadlockExample().Deadlock(), null);

        }
    }
}

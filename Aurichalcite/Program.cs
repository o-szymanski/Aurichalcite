using BenchmarkDotNet.Running;

namespace Aurichalcite
{
    public class Program
    {
        public static void Main()
        {        
            _ = BenchmarkRunner.Run<Benchmark>();
            Console.ReadKey();
        }
    }
}

using Aurichalcite.Benchmarks;
using BenchmarkDotNet.Running;

namespace Aurichalcite
{
    public class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<StringCreate>();
            Console.ReadKey();
        }
    }
}

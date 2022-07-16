using BenchmarkDotNet.Attributes;
using System.Text;

namespace Aurichalcite
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Benchmark]
        public string CreateStrings()
        {
            string result = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                result += i;
            }
            return result;
        }

        [Benchmark(Baseline = true)]
        public string CreateStringBuilder()
        {
            StringBuilder stringBuilder = new();
            for (int i = 0; i < 100; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }
    }
}

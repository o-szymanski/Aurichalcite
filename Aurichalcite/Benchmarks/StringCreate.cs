using BenchmarkDotNet.Attributes;
using System.Text;

namespace Aurichalcite.Benchmarks
{
    [MemoryDiagnoser]
    public class StringCreate
    {
        [Benchmark]
        public void CreateStrings()
        {
            string result = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                result += i;
            }
            _ = result;
        }

        [Benchmark]
        public void CreateStringBuilder()
        {
            StringBuilder stringBuilder = new();
            for (int i = 0; i < 100; i++)
            {
                stringBuilder.Append(i);
            }
            _ = stringBuilder.ToString();
        }
    }
}

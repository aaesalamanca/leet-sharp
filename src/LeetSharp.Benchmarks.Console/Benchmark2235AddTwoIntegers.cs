using BenchmarkDotNet.Attributes;
using static LeetSharp.Solutions.Library.Problem2235AddTwoIntegers;

namespace LeetSharp.Benchmarks.Console;

[MemoryDiagnoser]
public class Benchmark2235AddTwoIntegers
{
    // Uncomment the data set to run the benchmark against.
    public IEnumerable<object[]> Data()
    {
        yield return [12, 5];
        // yield return [-10, 4];
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int Bench_Sum(int num1, int num2) => Sum(num1, num2);
}

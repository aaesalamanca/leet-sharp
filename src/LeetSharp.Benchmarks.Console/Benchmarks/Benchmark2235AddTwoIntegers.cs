using BenchmarkDotNet.Attributes;
using LeetSharp.Solutions.Library.Implementations;

namespace LeetSharp.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Benchmark2235AddTwoIntegers
{
    private readonly Problem2235AddTwoIntegers _problem2235AddTwoIntegers = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<object[]> Data()
    {
        yield return [12, 5];
        // yield return [-10, 4];
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int Solution(int num1, int num2) => _problem2235AddTwoIntegers.Sum(num1, num2);
}

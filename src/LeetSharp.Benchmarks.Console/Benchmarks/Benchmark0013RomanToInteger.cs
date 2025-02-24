using BenchmarkDotNet.Attributes;
using LeetSharp.Solutions.Library.Implementations;

namespace LeetSharp.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Benchmark0013RomanToInteger
{
    private readonly Problem0013RomanToInteger _problem0013RomanToInteger = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<string> Data()
    {
        yield return "III";
        // yield return "LVIII";
        // yield return "MCMXCIV";
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int Solution(string s) => _problem0013RomanToInteger.RomanToInt(s);
}

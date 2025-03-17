using BenchmarkDotNet.Attributes;
using static LeetSharp.Solutions.Library.Problem0013RomanToInteger;

namespace LeetSharp.Benchmarks.Console;

[MemoryDiagnoser]
public class Benchmark0013RomanToInteger
{
    // Uncomment the data set to run the benchmark against.
    public IEnumerable<string> Data()
    {
        yield return "III";
        // yield return "LVIII";
        // yield return "MCMXCIV";
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int Bench_RomanToInt(string s) => RomanToInt(s);
}

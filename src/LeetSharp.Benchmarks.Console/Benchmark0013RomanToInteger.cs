using BenchmarkDotNet.Attributes;
using LeetSharp.Solutions.Library;

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
    public int RomanToInt(string s) => Problem0013RomanToInteger.RomanToInt(s);
}

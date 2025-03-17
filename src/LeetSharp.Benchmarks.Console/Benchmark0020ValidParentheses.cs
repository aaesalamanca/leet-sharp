using BenchmarkDotNet.Attributes;
using static LeetSharp.Solutions.Library.Problem0020ValidParentheses;

namespace LeetSharp.Benchmarks.Console;

[MemoryDiagnoser]
public class Benchmark0020ValidParentheses
{
    // Uncomment the data set to run the benchmark against.
    public IEnumerable<string> Data()
    {
        yield return "()";
        // yield return "()[]{}";
        // yield return "(]";
        // yield return "([])";
        // yield return "]";
        // yield return "){";
        // yield return "(])";
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public bool Bench_IsValid(string s) => IsValid(s);
}

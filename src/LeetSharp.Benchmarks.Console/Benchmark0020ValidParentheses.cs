using BenchmarkDotNet.Attributes;
using LeetSharp.Solutions.Library;

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
    public bool IsValid(string s) => Problem0020ValidParentheses.IsValid(s);
}

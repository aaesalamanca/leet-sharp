using BenchmarkDotNet.Attributes;
using LeetSharp.Solutions.Library.Implementations;

namespace LeetSharp.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Benchmark0020ValidParentheses
{
    private readonly Problem0020ValidParentheses _problem0020ValidParentheses = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<string> Data()
    {
        // yield return "()";
        yield return "()[]{}";
        // yield return "(]";
        // yield return "([])";
        // yield return "]";
        // yield return "){";
        // yield return "(])";
    }

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public bool Solution(string s) => _problem0020ValidParentheses.IsValid(s);
}

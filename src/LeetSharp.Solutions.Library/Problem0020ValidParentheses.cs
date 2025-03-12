namespace LeetSharp.Solutions.Library;

public static class Problem0020ValidParentheses
{
    public static bool IsValid(string s)
    {
        var opens = new Stack<char>();

        foreach (var letter in s)
        {
            if (letter == '(' || letter == '[' || letter == '{')
            {
                opens.Push(letter);
            }
            else if (opens.Count == 0 || GetOpenFromClose(letter) != opens.Pop())
            {
                return false;
            }
        }

        return opens.Count == 0;
    }

    static char GetOpenFromClose(char close) =>
        close switch
        {
            ')' => '(',
            ']' => '[',
            '}' => '{',
            _ => '\0',
        };
}

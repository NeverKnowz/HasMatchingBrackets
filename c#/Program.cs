using System.Collections.Generic;
class TechAssesment
{
    static void Main(string[] args)
    {
        var testCases = new List<string>() { "<>", "><", "<<>", "\"\"", "<abc...xyz>" };

        foreach (string test in testCases)
        {
            var result = HasMatchingBrackets(test);
            System.Console.WriteLine($"{test}:{result}");
        }

    }

    static bool HasMatchingBrackets(string input)
    {
        var brackets = new List<char>();

        foreach (char c in input)
        {

            if (c == '<')
            {
                brackets.Add(c);
            }
            else if (c == '>')
            {
                if (brackets.Count == 0 || brackets.Last() != '<')
                {
                    return false;
                }

                brackets.RemoveAt(brackets.Count - 1);
            }
            else
            {
                continue;
            }
        }

        return brackets.Count == 0;
    }
}
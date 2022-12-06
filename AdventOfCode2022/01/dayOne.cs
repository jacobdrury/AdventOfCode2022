using Newtonsoft.Json;

namespace AdventOfCode2022._01;

public static class dayOne
{
    public static int RunProblemOne(string fileName)
    {
        var input = Utils.ReadFile($"./01/{fileName}");
        var totals = GetTotals(input);

        return totals.Max();
    }
    
    public static int RunProblemTwo(string fileName)
    {
        var input = Utils.ReadFile($"./01/{fileName}");
        var totals = GetTotals(input);
        totals.Sort();
        return totals.TakeLast(3).Sum();
    }

    private static List<int> GetTotals(IEnumerable<string> input)
    {
        var totals = input.Aggregate(new List<int> { 0 }, (totals, current) =>
        {
            if (string.IsNullOrEmpty(current))
                totals.Add(0);
            else
                totals[^1] += int.Parse(current);
            return totals;
        });

        return totals;
    }
}
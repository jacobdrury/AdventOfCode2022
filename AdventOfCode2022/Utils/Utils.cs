namespace AdventOfCode2022;

public static class Utils
{
    public static IEnumerable<string> ReadFile(string fileName)
    {
        var file = File.ReadAllText(fileName);
        return file.Trim().Split("\n");
    }
}
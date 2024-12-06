namespace AdventOfCode2024.answers;

public class Helpers
{
    public List<int>[] GenerateNumbers()
    {
        List<int>[] numbers = new List<int>[2];
        numbers[0] = new List<int>();
        numbers[1] = new List<int>();
        String[] lines = File.ReadAllLines("C:/Users/nanda/RiderProjects/AdventOfCode2024/AdventOfCode2024/answers/data.txt");
        foreach (string line in lines)
        {
            string[] values = line.Split(",");
            numbers[0].Add(int.Parse(values[0]));
            numbers[1].Add(int.Parse(values[1]));
        }

        return numbers;
    }
}
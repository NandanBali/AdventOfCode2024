namespace AdventOfCode2024.dayone;

public class DayOne
{
    private List<int>[] GenerateNumbers()
    {
        List<int>[] numbers = new List<int>[2];
        numbers[0] = new List<int>();
        numbers[1] = new List<int>();
        String[] lines = File.ReadAllLines("C:/Users/nanda/RiderProjects/AdventOfCode2024/AdventOfCode2024/dayone/data.txt");
        foreach (string line in lines)
        {
            string[] values = line.Split(",");
            numbers[0].Add(int.Parse(values[0]));
            numbers[1].Add(int.Parse(values[1]));
        }

        return numbers;
    }

    private int CountDistances(List<int> sideOne, List<int> sideTwo)
    {
        int distances = 0;
        for (int i = 0; i < sideOne.Count; i++)
        {
            distances += Math.Abs(sideOne[i] - sideTwo[i]);
        }

        return distances;
    }
    public void Run()
    {
        List<int>[] numbers = GenerateNumbers();
        numbers[0].Sort();
        numbers[1].Sort();
        int distances = CountDistances(numbers[0], numbers[1]);
        Console.WriteLine(distances.ToString());
    }
}
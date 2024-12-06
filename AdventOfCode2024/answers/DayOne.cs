namespace AdventOfCode2024.answers;

public class DayOne
{
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
        Helpers helper = new Helpers();
        List<int>[] numbers = helper.GenerateNumbers();
        numbers[0].Sort();
        numbers[1].Sort();
        int distances = CountDistances(numbers[0], numbers[1]);
        Console.WriteLine(distances);
    }
}
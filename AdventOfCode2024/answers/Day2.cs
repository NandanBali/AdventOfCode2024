namespace AdventOfCode2024.answers;

public class Day2
{
    private int CalculateSimilarity(List<int> sideOne, List<int> sideTwo)
    {
        int similarity = 0;
        foreach (int element in sideOne)
        {
            List<int> instances = sideTwo.FindAll(e => e == element);
            similarity += element * instances.Count;
        }

        return similarity;
    }
    
    public void Run()
    {
        Helpers helper = new();
        List<int>[] numbers = helper.GenerateNumbers();
        int similarity = CalculateSimilarity(numbers[0], numbers[1]);
        Console.WriteLine(similarity);
    }
}
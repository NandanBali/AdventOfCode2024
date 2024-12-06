namespace AdventOfCode2024.daytwo;

public class Helpers
{
    public List<int[]> CreateReport()
    {
        List<int[]> numbers = new List<int[]>();
        String[] lines = File.ReadAllLines("C:\\Users\\nanda\\RiderProjects\\AdventOfCode2024\\AdventOfCode2024\\daytwo\\data-day-two.txt");
        foreach (var line in lines)
        {
            String[] values = line.Split(' ');
            int[] lineNumbers = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                lineNumbers[i] = int.Parse(values[i]);
            }
            numbers.Add(lineNumbers);
        }
        return numbers;
    }
    
}
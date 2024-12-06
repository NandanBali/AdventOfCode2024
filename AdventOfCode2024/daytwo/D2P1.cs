namespace AdventOfCode2024.daytwo;

public class D2P1
{
    private bool checkDescending(int[] report)
    {
        for (int i = 0; i < report.Length - 1; i++)
        {
            if (report[i] < report[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    private bool checkAscending(int[] report)
    {
        for (int i = 0; i < report.Length - 1; i++)
        {
            if (report[i] > report[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    private bool CheckDifference(int[] report)
    {
        for (int i = 0; i < report.Length - 1; i++)
        {
            if (!(Math.Abs(report[i] - report[i + 1]) >= 1 && Math.Abs(report[i] - report[i + 1]) <= 3))
            {
                return false;
            }
        }

        return true;
    }
    
    public void Run()
    {
        Helpers helper = new Helpers();
        int safeReports = 0;
        foreach (var numbers in helper.CreateReport())
        {
            if ((checkAscending(numbers) || checkDescending(numbers)) && CheckDifference(numbers))
            {
                safeReports++;
            }
        }
        Console.WriteLine(safeReports);
    }
}
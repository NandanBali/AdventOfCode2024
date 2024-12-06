using AdventOfCode2024.answers;
using AdventOfCode2024.daytwo;

public class Program
{
    public static void Main()
    {
        DayOne dayOne = new DayOne();
        Day2 day2 = new Day2();
        Console.Write($"Day 1 Pt. 1: ");
        dayOne.Run();
        Console.Write($"\nDay 1 Pt. 2: ");
        day2.Run();
        Console.Write($"\nDay 2 Pt. 1: ");
        D2P1 d2P1 = new D2P1();
        d2P1.Run();
    }
}
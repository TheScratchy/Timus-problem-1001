using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var inputs = System.Text.RegularExpressions.Regex.Split(Console.In.ReadToEnd(), @"\s+").ToList();
        inputs.RemoveAll(i => !long.TryParse(i, out _));

        inputs.Reverse();
        foreach (var i in inputs)
        {
            Console.WriteLine((decimal)Math.Sqrt(long.Parse(i)));
        }
    }
}
﻿Console.WriteLine("AOC - Day 1\n\n");

foreach (var input in new[] { "sample.txt", "input.txt" })
{
    Console.WriteLine($"[{input}]\n");

    var values = File.ReadAllLines(input)
        .Select(line => Convert.ToInt32(line))
        .ToList();

    var part1 = values
        .Select((val, i) => i > 0 && val > values[i - 1])
        .Where(isIncrease => isIncrease)
        .Count();

    Console.WriteLine($"Part 1: {part1}");

    values = values
        .Select((val, i) => values.Skip(i).Take(3).Sum())
        .ToList();

    var part2 = values
        .Select((val, i) => i > 0 && val > values[i - 1])
        .Where(isIncrease => isIncrease)
        .Count();

    Console.WriteLine($"Part 2: {part2}\n");
}

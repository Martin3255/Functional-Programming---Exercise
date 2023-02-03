int[] range = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();

bool isEven = Console.ReadLine() == "even";

Predicate<int> match;

Func<int, int, List<int>> generateRange = (start, end) =>
{
    List<int> range = new();

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }
    return range;
};

string command = Console.ReadLine();


List<int> numbers = generateRange(range[0], range[1]);

if (command == "even")
{
    match = number => number % 2 == 0;
}
else
{
    match = number => number % 2 != 0;
}
foreach (var number in numbers)
{
    if (match(number))
    {
        Console.Write($"{number} ");
    }
    
}
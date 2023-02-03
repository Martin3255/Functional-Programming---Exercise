Func<int[], int> func = (numbers) =>
{

    int min = int.MaxValue;

    foreach (var item in numbers)
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
};

int[] numbers = Console.ReadLine()
                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToArray();

Console.WriteLine(func(numbers));
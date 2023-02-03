using System.Data;

List<int> numbers = new List<int>(Console.ReadLine()
          .Split()
          .Select(int.Parse)
          .ToList());

Func<string, List<int>, List<int>> calculate = (command, numbers) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        switch (command)
        {
            case "add":
                result.Add(number + 1);
                break;
            case "subtract":
                result.Add(number - 1);
                break;
            case "multiply":
                result.Add(number * 2);
                break;
        }
    }
    return result;
};

Action<List<int>> print = numbers =>
Console.WriteLine(string.Join(" ", numbers));

string command = Console.ReadLine();

while (command != "end")
{
    if (command == "print")
    {
        print(numbers);
    }
    else
    {
        numbers = calculate(command, numbers);
    }
    command = Console.ReadLine();
}
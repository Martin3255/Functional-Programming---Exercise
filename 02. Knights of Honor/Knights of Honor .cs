using System.Reflection;

Action<string[], string> action = (names, title) =>
{
	foreach (var name in names)
	{
		Console.WriteLine($"{title} {name}");
	}
};

string[] names = Console.ReadLine().Split().ToArray();

action(names, "Sir");
using Linq_tasks;

List<string> strings = new List<string>() { "dfsd", "dfasas", "de", "asd"};

List<int> numbers = Linq_Tasks.Task2(strings).ToList();

foreach (var number in numbers)
{
    Console.WriteLine(number);
}
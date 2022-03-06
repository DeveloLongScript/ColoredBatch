// See https://aka.ms/new-console-template for more information
if (args[0] == "write")
{
    Console.ForegroundColor = (ConsoleColor)int.Parse(args[1]);
    Console.BackgroundColor = (ConsoleColor)int.Parse(args[2]);
    List<string> list = new List<string>();
    for (int i = 3; i < args.Count(); i++)
    {
        list.Add(args[i]);
    }

    Console.Write(string.Join(" ", list.ToArray()));
}
if (args[0] == "writeline")
{
    Console.ForegroundColor = (ConsoleColor)int.Parse(args[1]);
    Console.BackgroundColor = (ConsoleColor)int.Parse(args[2]);
    List<string> list = new List<string>();
    for (int i = 3; i < args.Count(); i++)
    {
        list.Add(args[i]);
    }

    Console.WriteLine(string.Join(" ", list.ToArray()));
}
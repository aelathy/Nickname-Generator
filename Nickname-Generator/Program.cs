// Nickname Generator
#nullable disable
Console.Clear();

string john = "John";
string doe = "Doe";
int alias = 0;

var list = new List<string> { "-", "the Coder", "the Jester", "the Scientist", "the Winner", "the Survivor", "Fast", "the Cautious", "the Focused" };
Random rnd = new Random();

bool loop = true;
while (loop)
{
    // Main Menu Loop
    Console.WriteLine($"Main Menu ({john} {list[alias]} {doe})");
    Console.WriteLine("1. Change Name");
    Console.WriteLine("2. Display a Random Nickname");
    Console.WriteLine("3. Display All Nicknames");
    Console.WriteLine("4. Add a Nickname");
    Console.WriteLine("5. Remove a Nickname");
    Console.WriteLine("6. Exit");
    string menuOption = Console.ReadLine().ToLower();
    Console.WriteLine();

    if (menuOption == "1")
    {
        Console.Write("Please enter first name: ");
        john = Console.ReadLine();
        Console.Write("Please enter last name: ");
        doe = Console.ReadLine();
        Console.WriteLine($"Current name is {john} {doe}");
    }
    else if (menuOption == "2")
    {
        alias = rnd.Next(list.Count);
        Console.WriteLine($"Your nickname is now {john} {list[alias]} {doe}");
    }
    else if (menuOption == "3")
    {
        // list.ToList().ForEach(i => Console.WriteLine(john + " " + i.ToString() + " " + doe));
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(john + " " + list[i] + " " + doe);
        }
    }
    else if (menuOption == "4")
    {
        Console.Write("ADD A NICKNAME: ");
        string newAlias = Console.ReadLine();
        if (list.Contains(newAlias))
        {
            Console.WriteLine("Nickname is already in the list.");
        }
        else
        {
            list.Add(newAlias);
        }
    }
    else if (menuOption == "5")
    {
        Console.Write("REMOVE AN ALIAS: ");
        string removedAlias = Console.ReadLine();
        if (list.Contains(removedAlias))
        {
            list.Remove(removedAlias);
            Console.WriteLine(removedAlias + " removed from the nickname list");
        }
        else
        {
            Console.WriteLine("Not found.");
        }
    }
    else if (menuOption == "6")
    {
        break;
    }
}
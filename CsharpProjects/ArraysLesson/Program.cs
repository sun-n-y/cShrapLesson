// string[] iDs = { "A", "B", "C" };

// // iDs[0] = "A123";
// // iDs[1] = "B123";
// // iDs[2] = "C123";

// // iDs[3] = "D123";

// iDs[0] = "ZZZZ";

// Console.WriteLine($"First: {iDs[0]}");
// Console.WriteLine($"Second: {iDs[1]}");
// Console.WriteLine($"Third: {iDs[2]}");

// Console.WriteLine($"Length: {iDs.Length}");

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;

// foreach (int value in inventory)
// {
//     bin++;
//     sum += value;
//     Console.WriteLine($"bin = {bin}, running total = {sum}");
// };

// Console.WriteLine($"bin = {bin}, grand total = {sum}");


string[] iDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string item in iDs)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine($"{item} starts with letter B");
    }
}


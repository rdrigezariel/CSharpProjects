

Console.Write("Please enter your first name: ");
string firstName = Console.ReadLine();

Console.WriteLine("Call from IF statement");
if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy") Console.WriteLine("Hello, Professor!");
else Console.WriteLine("Hello, Student!");

Console.WriteLine("Call from Switch statement");
switch (firstName.ToLower())
{
    case "tim" or "timothy":
        Console.WriteLine("Hello, Professor!");
        break;
    default:
        Console.WriteLine("Hello, Student!");
        break;
}
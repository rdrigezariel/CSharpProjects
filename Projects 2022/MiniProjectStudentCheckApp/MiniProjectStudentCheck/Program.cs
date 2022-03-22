
Console.Write("Please enter your first name: ");
string firstName = Console.ReadLine();
string formattedName = firstName;

Console.Write("Please enter your age: ");
if (!int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("You did not provide a valid age, run program again");
    return;
}

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue") 
    formattedName = $"Professor {firstName}";

if (age < 21) Console.WriteLine($"I recommend you wait {21 - age} year(s), {formattedName}");
else Console.WriteLine($"Welcome to class, {formattedName}");



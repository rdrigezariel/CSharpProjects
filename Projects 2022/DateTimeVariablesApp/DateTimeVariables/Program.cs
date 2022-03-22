
Console.Write("Please enter your age: ");
bool isValid = int.TryParse(Console.ReadLine(), out int usersAge);

if (isValid)
{
    int futureAge = usersAge + 25;
    int pastAge = usersAge - 25;
    
    Console.WriteLine($"In 25 years, you will be: {futureAge}");
    Console.WriteLine($"25 years ago, you were: {pastAge}");
}
else
{
    Console.WriteLine("Invalid age, please try again!");
}



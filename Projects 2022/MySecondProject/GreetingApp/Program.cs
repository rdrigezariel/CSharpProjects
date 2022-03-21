/*
 Program steps:
 - Welcome User to App
 - Ask for First Name
 - Greet user by name
 */

// Welcome User to App
Console.WriteLine("Welcome to the Greeting Application!");
Console.WriteLine("This application was built by Ariel Rodriguez");
Console.WriteLine("---------------------------------------------\n");

// Ask for First Name
Console.Write("What is your first name: ");
string firstName;
firstName = Console.ReadLine();

// Greet user by name
Console.WriteLine($"Hello, {firstName}!");
Console.WriteLine("Thank you for using my application.");
Console.ReadLine();
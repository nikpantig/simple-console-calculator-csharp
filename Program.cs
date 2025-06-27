Console.WriteLine("Hello");
Console.WriteLine("Input the first number:");
string UserInput1 = Console.ReadLine();

Console.WriteLine("Input the second number:");
string UserInput2 = Console.ReadLine();

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
string UserChoice = Console.ReadLine();

int parsedUserInput1 = int.Parse(UserInput1);
int parsedUserInput2 = int.Parse(UserInput2);

if ((UserChoice == "A" || UserChoice == "a"))
{
    int sum = parsedUserInput1 + parsedUserInput2;
    Console.WriteLine($"{parsedUserInput1} + {parsedUserInput2} = {sum}");
}
else if ((UserChoice == "S" || UserChoice == "s"))
{
    int difference = parsedUserInput1 - parsedUserInput2;
    Console.WriteLine($"{parsedUserInput1} - {parsedUserInput2} = {difference}");
}
else if ((UserChoice == "M" || UserChoice == "m"))
{
    int product = parsedUserInput1 * parsedUserInput2;
    Console.WriteLine($"{parsedUserInput1} * {parsedUserInput2} = {product}");
}
else
{
    Console.WriteLine("Invalid choice!");
    Console.WriteLine("Press any key to close.");
}
Console.WriteLine("Press any key to close.");

Console.ReadKey();

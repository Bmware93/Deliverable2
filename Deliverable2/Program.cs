// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to the Coin flip challenge!");
Console.WriteLine("Please enter your name: ");

string name = Console.ReadLine();

Console.WriteLine($"Welcome {name}! Do you want to do the coin flip challenge? Yes/No");

string userResponse = Console.ReadLine();
var modifiedResponse = userResponse.ToLower();

while (modifiedResponse != "yes" && modifiedResponse != "no")
{
    Console.WriteLine("You've entered an invalid entry. Please enter yes or no.");
    userResponse = Console.ReadLine();
    modifiedResponse = userResponse;
}


if (modifiedResponse == "no")
{
    Console.Write($"You are a coward {name}.");
} else  {
    Console.WriteLine("Heads or Tails?");
    Console.ReadLine();
}




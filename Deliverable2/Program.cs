// See https://aka.ms/new-console-template for more information

string[] coinValues = { "heads", "tails" };
int correctGuesses = 0;

//Function to convert the players guess to a 0 for heads or 1 for tails
static int convertGuessToInt(string guess)
{
    if (guess == "heads")
    {
        return 0;
    }
    else if (guess == "tails")
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

//Start of program
Console.WriteLine("Welcome to the Coin flip challenge!");
Console.WriteLine("Please enter your name: ");

string name = Console.ReadLine();

Console.WriteLine($"Welcome {name}! Do you want to do the coin flip challenge? Yes/No");
Console.WriteLine();

string userResponse = Console.ReadLine();
var modifiedResponse = userResponse.ToLower();

//prompt will repeat until user enters a vaild answer of yes or no.
while (modifiedResponse != "yes" && modifiedResponse != "no")
{
    Console.WriteLine("You've entered an invalid entry. Please enter yes or no.");
    userResponse = Console.ReadLine();
    modifiedResponse = userResponse;
}

//if user says no, program will end.
if (modifiedResponse == "no")
{
    Console.Write($"You are a coward {name}.");
}
else
{
    Console.WriteLine($"Good luck {name}!");

    for (int attemptsLeft = 5; attemptsLeft != 0; attemptsLeft--)
    {
        
        //A random index from the coin values array is selected. with only 2 items in the array, it will be index 0 or 1
        Random rnd = new Random();
        int flippedCoin = rnd.Next(coinValues.Length);

        Console.WriteLine("Heads or Tails?");
        string guess = Console.ReadLine();
        string guessLowered = guess.ToLower();

        while (guessLowered != "heads" && guessLowered != "tails")
        {
            Console.WriteLine("You entered an invalid entry. Please enter heads or tails");
            guess = Console.ReadLine();
            guessLowered = guess.ToLower();
        }
        //function is called to convert the users answer to a zero or 1
        int guessAsInt = convertGuessToInt(guessLowered);

        if (guessAsInt == flippedCoin)
        {
            Console.WriteLine("Correct!");
            correctGuesses++;
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wrong!");
            Console.WriteLine();
        }

        
    }
    Console.WriteLine($"Thank you for playing {name}! You got a score of {correctGuesses}.");
    Console.ReadLine();
}




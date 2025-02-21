// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!\nWhat is your name?");
var username = Console.ReadLine();

var score = 0;

Console.WriteLine($"\nWelcome {username}, do you want to do the COIN FLIP CHALLENGE?");
var choice = Console.ReadLine();

if (choice == "yes" || choice == "y" || choice == "Yes")
{
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine("Heads or Tails");
        var answer = Console.ReadLine();
        
        // Only picks 0 right now
        Random random = new Random();
        int randomNumber = random.Next(0, 1);

        if (answer == "Heads" || answer == "heads" && randomNumber == 0)
        {
            score += 1;
            Console.WriteLine("Correct!");
        } else if (answer == "Tails" || answer == "tails" && randomNumber == 1)
        {
            score += 1;
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
    }
    Console.WriteLine($"Thank you {username}! You got a score of {score}!");
}
else
{
    Console.WriteLine($"You are a coward {username}");
}
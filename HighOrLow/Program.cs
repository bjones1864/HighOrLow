var rand = new Random();

Console.WriteLine("Let's play a guessing game!  Try to guess the number, which will be an integer between 1 and 100.");

do
{
    int n = rand.Next(1, 101);
    int guesses = 0;

    do
    {
        Console.WriteLine("Guess a number between 1 and 100:");
        int guess = int.Parse(Console.ReadLine());
        
        if(guess > n)
        {
            Console.WriteLine($"{guess} is too high.");
            guesses++;
        }
        else if(guess < n)
        {
            Console.WriteLine($"{guess} is too low.");
            guesses++;
        }
        else
        {
            Console.WriteLine($"{guess} is correct!  Nice job!");
            guesses++;
            break;
        }

    } while (true);

    Console.WriteLine("Would you like to play again?  Please enter y or yes to play again");
    string playAgain = Console.ReadLine();
    
    if (playAgain.ToLower() != "y" && playAgain.ToLower() != "yes") break;

} while (true);
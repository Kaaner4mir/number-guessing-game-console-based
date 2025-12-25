class Program
{
    static void Main()
    {
        while (true)
        {
            Random random = new Random();
            int number = random.Next(1, 101);

            short attempt = 0;

            while (attempt < 10)
            {
                Console.Write("\nI picked a number. Guess what it is: ");
                int guess = Convert.ToInt32(Console.ReadLine());


                if (guess == number)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations! You've won! The number I guessed is {number}.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (guess < number)
                    {
                        Console.WriteLine($"The number I picked is higher!. You have {10 - attempt} attempts left.");
                        attempt++;
                    }
                    else
                    {
                        Console.WriteLine($"The number I picked is lower!. You have {10 - attempt} attempts left.");
                        attempt++;
                    }
                    Console.ResetColor();
                }

                if (attempt == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You have lost. The number I guessed is {number}.");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
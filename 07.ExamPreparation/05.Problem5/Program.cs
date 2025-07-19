
int playerOneEggs = int.Parse(Console.ReadLine());
int playerTwoEggs = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

while (input != "End")
{
    switch (input)
    {
        case "one":
            playerTwoEggs--;

            if (playerTwoEggs == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {playerOneEggs} eggs left.");
                Environment.Exit(0);
            }
            break;
        case "two":
            playerOneEggs--;

            if (playerOneEggs == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {playerTwoEggs} eggs left.");
                Environment.Exit(0);
            }
            break;
    }

    input = Console.ReadLine();
}

if (playerOneEggs > 0 && playerTwoEggs > 0)
{
    Console.WriteLine($"Player one has {playerOneEggs} eggs left.");
    Console.WriteLine($"Player two has {playerTwoEggs} eggs left.");
}


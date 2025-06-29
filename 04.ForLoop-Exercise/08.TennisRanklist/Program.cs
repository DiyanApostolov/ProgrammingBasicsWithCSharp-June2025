
int countOfTournaments = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());

//"W", "F" или "SF"
// W - ако е победител получава 2000 точки
// F - ако е финалист получава 1200 точки
// SF - ако е полуфиналист получава 720 точки

int collectedPoints = 0;
int winCounter = 0;

for (int i = 0; i < countOfTournaments; i++)
{
    string stage = Console.ReadLine();

    switch (stage)
    {
        case "W":
            collectedPoints += 2000;
            winCounter++;
            break;
        case "F":
            collectedPoints += 1200;
            break;
        case "SF":
            collectedPoints += 720;
            break;
    }
}

int averagePoints = collectedPoints / countOfTournaments;
double percentWinning = (double)winCounter / countOfTournaments * 100;
int finalPoints = collectedPoints + startingPoints;

Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{percentWinning:F2}%");
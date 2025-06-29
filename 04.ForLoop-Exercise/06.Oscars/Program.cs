
string nameOfActor = Console.ReadLine();
double actorPoints = double.Parse(Console.ReadLine());
int coutOfJury = int.Parse(Console.ReadLine());

for (int i = 0; i < coutOfJury; i++)
{
    string juryMemberName = Console.ReadLine();
    double pointsFromJury = double.Parse(Console.ReadLine());

    double currentPoints = juryMemberName.Length * pointsFromJury / 2;
    actorPoints += currentPoints;

    if (actorPoints >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {actorPoints:F1}!");
        break;
    }
}

if (actorPoints < 1250.5)
{
    double neededPoints = 1250.5 - actorPoints;
    Console.WriteLine($"Sorry, {nameOfActor} you need {neededPoints:F1} more!");
}
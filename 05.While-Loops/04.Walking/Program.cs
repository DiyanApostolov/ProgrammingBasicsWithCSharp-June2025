
int allSteps = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "Going home")
    {
        int stepsToHome = int.Parse(Console.ReadLine());
        allSteps += stepsToHome;
        break;
    }

    int currentSteps = int.Parse(input);
    allSteps += currentSteps;

    if (allSteps >= 10000)
        break;
}

if (allSteps >= 10000)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{allSteps - 10000} steps over the goal!");
}
else
{
    Console.WriteLine($"{10000 - allSteps} more steps to reach goal.");
}
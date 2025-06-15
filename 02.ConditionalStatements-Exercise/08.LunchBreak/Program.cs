// Input
string nameOfMovie = Console.ReadLine();
int timeForOneEpisode = int.Parse(Console.ReadLine());
int lunchBreakTime = int.Parse(Console.ReadLine());

// Calculations
double eatTime = lunchBreakTime / 8.0;
double restTime = lunchBreakTime / 4.0;

double neededTime = eatTime + restTime + timeForOneEpisode;

// Output
double difference = Math.Abs(lunchBreakTime - neededTime);

if (lunchBreakTime >= neededTime)
{
    Console.WriteLine($"You have enough time to watch {nameOfMovie} and left with {Math.Ceiling(difference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {nameOfMovie}, you need {Math.Ceiling(difference)} more minutes.");
}
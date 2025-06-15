
// Input
double worldRecordInSeconds = double.Parse(Console.ReadLine());
double distanceToSwim = double.Parse(Console.ReadLine());
double swimOneMeterInSeconds = double.Parse(Console.ReadLine());

// Calculations
double timeToSwim = distanceToSwim * swimOneMeterInSeconds;

double waterResistant = Math.Floor(distanceToSwim / 15) * 12.5;

double ivanTime = timeToSwim + waterResistant;

// Output
if (ivanTime < worldRecordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:F2} seconds.");
}
else
{
    double neededTime = ivanTime - worldRecordInSeconds;
    Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
}

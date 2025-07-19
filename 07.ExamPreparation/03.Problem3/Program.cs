
double budget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());

double priceForOneDay = 0;

if (destination == "Dubai")
{
    if (season == "Summer")
    {
        priceForOneDay = 40000 * 0.7; // -30%
    }
    else if (season == "Winter")
    {
        priceForOneDay = 45000 * 0.7; // -30%
    }
}
else if (destination == "Sofia")
{
    if (season == "Summer")
    {
        priceForOneDay = 12500 * 1.25; // +25%
    }
    else if (season == "Winter")
    {
        priceForOneDay = 17000 * 1.25; // +25%
    }
}
else if (destination == "London")
{
    if (season == "Summer")
    {
        priceForOneDay = 20250;
    }
    else if (season == "Winter")
    {
        priceForOneDay = 24000;
    }
}

double finalPrice = countOfDays * priceForOneDay;

double diff = Math.Abs(budget - finalPrice);

if (budget >= finalPrice)
{
    Console.WriteLine($"The budget for the movie is enough! We have {diff:F2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {diff:F2} leva more!");
}
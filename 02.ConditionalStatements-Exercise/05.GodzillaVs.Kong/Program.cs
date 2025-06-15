// Input
double movieBudget = double.Parse(Console.ReadLine());
int countOfStatists = int.Parse(Console.ReadLine());
double priceOfDres = double.Parse(Console.ReadLine());

// Calculations
double sumOfDecor = 0.1 * movieBudget;
double sumOfDres = countOfStatists * priceOfDres;

if (countOfStatists > 150)
{
    sumOfDres *= 0.9; // намаляме с 10%
}

double sumMovie = sumOfDres + sumOfDecor;

// Output
if (movieBudget >= sumMovie)
{
    double moneyLeft = movieBudget - sumMovie;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
}
else
{
    double moneyNeeded = sumMovie - movieBudget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
}
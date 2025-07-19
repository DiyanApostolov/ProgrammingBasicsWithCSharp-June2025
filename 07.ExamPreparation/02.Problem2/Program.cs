
double budget = double.Parse(Console.ReadLine());
int countOfNights = int.Parse(Console.ReadLine());
double priceForOneNight = double.Parse(Console.ReadLine());
int percentAdditionalExpenses = int.Parse(Console.ReadLine());

if (countOfNights > 7)
{
    priceForOneNight *= 0.95; // -5%
}

double priceForAllNights = countOfNights * priceForOneNight;
double additionalExpenses = budget * percentAdditionalExpenses / 100;

double finalPrice = priceForAllNights + additionalExpenses;

if (budget >= finalPrice)
{
    double moneyLeft = budget - finalPrice;

    Console.WriteLine($"Ivanovi will be left with {moneyLeft:F2} leva after vacation.");
}
else
{
    double moneyNeeded = finalPrice - budget;

    Console.WriteLine($"{moneyNeeded:F2} leva needed.");
}

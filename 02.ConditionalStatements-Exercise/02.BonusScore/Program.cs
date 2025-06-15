
// Input
int number = int.Parse(Console.ReadLine());

// Calculations
double bonusPoints = 0;

if (number <= 100)
{
    bonusPoints = 5;
}
else if (number <= 1000)
{
    bonusPoints = number * 0.2; // 20%
}
else 
{
    bonusPoints = number * 0.1; // 10% 
}

if (number % 2 == 0)
{
    bonusPoints += 1;
}
else if (number % 10 == 5)
{
    bonusPoints += 2;
}

// Output
Console.WriteLine(bonusPoints);
Console.WriteLine(number + bonusPoints);

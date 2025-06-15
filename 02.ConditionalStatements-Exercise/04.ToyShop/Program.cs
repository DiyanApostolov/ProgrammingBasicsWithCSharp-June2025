// Input
double vacationPrice = double.Parse(Console.ReadLine());
int puuzzelCount = int.Parse(Console.ReadLine());
int dollsCount = int.Parse(Console.ReadLine());
int bearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

// Calculations
//•	Пъзел - 2.60 лв.
//•	Говореща кукла - 3 лв.
//•	Плюшено мече - 4.10 лв.
//•	Миньон - 8.20 лв.
//•	Камионче - 2 лв.

double puzzelIncome = puuzzelCount * 2.60;
double dollsIncome = dollsCount * 3;
double bearsIncome = bearsCount * 4.10;
double minionsIncome = minionsCount * 8.20;
double trucksIncome = trucksCount * 2;

double allIncome = puzzelIncome + dollsIncome + bearsIncome + minionsIncome + trucksIncome;

int allToysCount = puuzzelCount + dollsCount + bearsCount + minionsCount + trucksCount;

if (allToysCount >= 50)
{
    double discount = allIncome * 0.25; // 25%

    allIncome -= discount;
}

double rent = allIncome * 0.1; // 10%

double finalIncome = allIncome - rent;

// Output
if (finalIncome >= vacationPrice)
{
    double moneyLeft = finalIncome - vacationPrice;

    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
}
else
{
    double moneyNeeded = vacationPrice - finalIncome;

    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
}

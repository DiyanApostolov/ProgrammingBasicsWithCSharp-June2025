
double neededMoneyForVacation = double.Parse(Console.ReadLine());
double savedMoney = double.Parse(Console.ReadLine());

int spendCounter = 0;
int daysCounter = 0;

while (savedMoney < neededMoneyForVacation)
{
    //"spend" или "save"
    string action = Console.ReadLine();
    double currentMoney = double.Parse(Console.ReadLine());

    daysCounter++;

    if (action == "spend")
    {
        savedMoney -= currentMoney;
        spendCounter++;

        if (spendCounter == 5)
            break;

        if (savedMoney < 0)
            savedMoney = 0;
    }
    else if (action == "save")
    {
        spendCounter = 0;

        savedMoney += currentMoney;
    }
}

if (spendCounter == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(daysCounter);
}
else
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}

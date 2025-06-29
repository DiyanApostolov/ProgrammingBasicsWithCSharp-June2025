
int yearsOld = int.Parse(Console.ReadLine());
double priceForWashingMaschine = double.Parse(Console.ReadLine());
int priceOfOneToy = int.Parse(Console.ReadLine());

int savedMoney = 0;
int moneyForBirthday = 10;
int countOfToys = 0;

for (int birthday = 1; birthday <= yearsOld; birthday++)
{
    if (birthday % 2 == 0)
    {
        savedMoney += moneyForBirthday;
        moneyForBirthday += 10; // увеливаме с 10лв за следващия РД
        savedMoney -= 1;        // брат й взема всеки път по 1 лев
    }
    else
    {
        countOfToys++;
    }
}

int moneyFromToys = countOfToys * priceOfOneToy;

savedMoney += moneyFromToys; // Прибавяме парите от продадените играчки

double diff = Math.Abs(savedMoney - priceForWashingMaschine);

if (savedMoney >= priceForWashingMaschine)
{
    Console.WriteLine($"Yes! {diff:F2}");
}
else
{
    Console.WriteLine($"No! {diff:F2}");
}

int countOfDays = int.Parse(Console.ReadLine());
double amountOfFood = double.Parse(Console.ReadLine());

int amountFoodEatenByDog = 0;
int amountFoodEatenByCat = 0;
double biscuits = 0;

for (int day = 1; day <= countOfDays; day++)
{
    int foodEatenByDogThisDay = int.Parse(Console.ReadLine());
    int foodEatenByCatThisDay = int.Parse(Console.ReadLine());

    amountFoodEatenByDog += foodEatenByDogThisDay;
    amountFoodEatenByCat += foodEatenByCatThisDay;

    if (day % 3 == 0)
    {
        biscuits += (foodEatenByDogThisDay + foodEatenByCatThisDay) * 0.10;
    }
}

double allEatenFood = amountFoodEatenByDog + amountFoodEatenByCat;

double percentEatenFood = allEatenFood / amountOfFood * 100;
double percentEatenFoodByDog = amountFoodEatenByDog / allEatenFood * 100;
double percentEatenFoodByCat = amountFoodEatenByCat / allEatenFood * 100;

Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
Console.WriteLine($"{percentEatenFood:F2}% of the food has been eaten.");
Console.WriteLine($"{percentEatenFoodByDog:F2}% eaten from the dog.");
Console.WriteLine($"{percentEatenFoodByCat:F2}% eaten from the cat.");

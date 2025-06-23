// Input
string typeOfFlowers = Console.ReadLine();
int countOfFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

// Calculations
//цвете               Роза	Далия	Лале	Нарцис	Гладиола
//Цена на брой в лева	5	3.80	2.80	   3	  2.50

//"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

double finalPrice = 0;

if (typeOfFlowers == "Roses")
{
    finalPrice = countOfFlowers * 5;

    if (countOfFlowers > 80)
        finalPrice *= 0.90; // -10%
}
else if (typeOfFlowers == "Dahlias")
{
    finalPrice = countOfFlowers * 3.80;

    if (countOfFlowers > 90)
        finalPrice *= 0.85; // -15%
}
else if (typeOfFlowers == "Tulips")
{
    finalPrice = countOfFlowers * 2.80;

    if (countOfFlowers > 80)
        finalPrice *= 0.85; // -15%
}
else if (typeOfFlowers == "Narcissus")
{
    finalPrice = countOfFlowers * 3;

    if (countOfFlowers < 120)
        finalPrice *= 1.15; // +15%
}
else if (typeOfFlowers == "Gladiolus")
{
    finalPrice = countOfFlowers * 2.50;

    if (countOfFlowers < 80)
        finalPrice *= 1.2; // +20%
}

double difference = Math.Abs(budget - finalPrice);

if (budget >= finalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
}
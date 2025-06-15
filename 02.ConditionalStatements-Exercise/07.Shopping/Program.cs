// Input
double budget = double.Parse(Console.ReadLine());
int countVideoCarts = int.Parse(Console.ReadLine());
int countProcessors = int.Parse(Console.ReadLine());
int countRamMemory = int.Parse(Console.ReadLine());

// Calculations
//•	Видеокарта – 250 лв./бр.

double priceForAllVideoCarts = countVideoCarts * 250;

double priceForOneProcessor = priceForAllVideoCarts * 0.35; // 35%
double priceForAllProcessors = countProcessors * priceForOneProcessor;

double priceForOneRamMemory = priceForAllVideoCarts * 0.1; // 10%
double proceForAllRamMemories = countRamMemory * priceForOneRamMemory;

double priceForAllComponents = priceForAllVideoCarts + priceForAllProcessors + proceForAllRamMemories;

if (countVideoCarts > countProcessors)
{
    double discount = priceForAllComponents * 0.15; // 15%

    priceForAllComponents -= discount;
}

// Output
double difference = Math.Abs(budget - priceForAllComponents);

if (budget >= priceForAllComponents)
{
    Console.WriteLine($"You have {difference:F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {difference:F2} leva more!");
}
// Input
int neededNylon = int.Parse(Console.ReadLine());
int neededPaint = int.Parse(Console.ReadLine());
int neededThinner = int.Parse(Console.ReadLine());
int neededHoursToWork = int.Parse(Console.ReadLine());

// Calculations
//•	Предпазен найлон - 1.50 лв. за кв. метър
//•	Боя - 14.50 лв. за литър
//•	Разредител за боя - 5.00 лв. за литър

double priceForNylon = (neededNylon + 2) * 1.50;
double priceForPaint = (neededPaint + (neededPaint * 0.1)) * 14.50;
double priceForThinner = neededThinner * 5;

double priceForAllMaterials = priceForNylon + priceForPaint + priceForThinner + 0.40;

double oneHourWork = priceForAllMaterials * 0.3;
double priceForWorkers = neededHoursToWork * oneHourWork;

double finalPrice = priceForAllMaterials + priceForWorkers;

// Output
Console.WriteLine(finalPrice);



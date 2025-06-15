// Input
int countPensPackages = int.Parse(Console.ReadLine());
int countMarkersPackages = int.Parse(Console.ReadLine());
int litersPreparation = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

// Calculations
//•	Пакет химикали - 5.80 лв. 
//•	Пакет маркери - 7.20 лв. 
//•	Препарат - 1.20 лв (за литър)

double priceForPens = countPensPackages * 5.80;
double priceFopMarkers = countMarkersPackages * 7.20;
double priceForPreparation = litersPreparation * 1.20;

double priceForAllMaterials = priceFopMarkers + priceForPens + priceForPreparation;

double discount = priceForAllMaterials * percentDiscount / 100;

double finalPrice = priceForAllMaterials - discount;

// Output
Console.WriteLine(finalPrice);
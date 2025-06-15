// Input
int countChikenMenus = int.Parse(Console.ReadLine());
int countFishMenus = int.Parse(Console.ReadLine());
int countVegetarianMenus = int.Parse(Console.ReadLine());

// Calculations
//•	Пилешко меню –  10.35 лв. 
//•	Меню с риба – 12.40 лв. 
//•	Вегетарианско меню  – 8.15 лв. 
//• Цена за доставка - 2.50 лв.

double priceForChikenMenus = countChikenMenus * 10.35;
double priceForFishMenus = countFishMenus * 12.40;
double priceForVegetarianMenus = countVegetarianMenus * 8.15;

double priceForAllMenus = priceForChikenMenus + priceForFishMenus + priceForVegetarianMenus;

double priceForDessert = priceForAllMenus * 0.2; // 0.2 -> 20%

double finalPrice = priceForAllMenus + priceForDessert + 2.50;

// Output
Console.WriteLine(finalPrice);

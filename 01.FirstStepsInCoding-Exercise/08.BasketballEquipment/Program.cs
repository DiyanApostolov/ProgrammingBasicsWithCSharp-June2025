// Input
int yearFee = int.Parse(Console.ReadLine());

// Calculations
double priceForSneakers = yearFee - (yearFee * 0.4);  // 0.4 -> 40%
double priceForJersey = priceForSneakers * 0.8;       // -20%
double priceForBall = priceForJersey / 4;
double priceForAccessories = priceForBall / 5;

double finalPrice = yearFee + priceForSneakers + priceForJersey + priceForBall + priceForAccessories;

// Output
Console.WriteLine(finalPrice);

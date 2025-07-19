
double strawberryPricePerKg = double.Parse(Console.ReadLine());
double amountOfBananas = double.Parse(Console.ReadLine());
double amountOfOranges = double.Parse(Console.ReadLine());
double amountOfRaspberry = double.Parse(Console.ReadLine());
double amountOfStrawberry = double.Parse(Console.ReadLine());

double raspberryPricePerKg = strawberryPricePerKg / 2; // -50%
double orangesPricePerKg = raspberryPricePerKg * 0.6; // -40%
double bananasPricePerKg = raspberryPricePerKg * 0.2; // -50%

double finalPrice = amountOfBananas * bananasPricePerKg +
                    amountOfOranges * orangesPricePerKg +
                    amountOfRaspberry * raspberryPricePerKg +
                    amountOfStrawberry * strawberryPricePerKg;

Console.WriteLine($"{finalPrice:F2}");



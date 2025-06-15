// Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int higth = int.Parse(Console.ReadLine());
double percentOccupied = double.Parse(Console.ReadLine());

// Calculations
int allVolume = length * width * higth;
double volumeInLiters = allVolume / 1000.0;

double neededLiters = volumeInLiters * (1 - percentOccupied / 100);

// Output
Console.WriteLine(neededLiters);
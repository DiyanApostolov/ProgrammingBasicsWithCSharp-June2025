// Input
int pagesForRead = int.Parse(Console.ReadLine());
int readPagesPerHour = int.Parse(Console.ReadLine());
int countOfDays = int.Parse(Console.ReadLine());

// Calculations
int neededTime = pagesForRead / readPagesPerHour;
int hoursReadPerDay = neededTime / countOfDays;

// Output
Console.WriteLine(hoursReadPerDay);


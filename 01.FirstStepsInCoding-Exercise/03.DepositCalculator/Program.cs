// Input
double deposit = double.Parse(Console.ReadLine());
int periodInMonths = int.Parse(Console.ReadLine());
double interestPerYear = double.Parse(Console.ReadLine());

// Calculations

double yearIncome = deposit * interestPerYear / 100; // годишен приход
double monthIncome = yearIncome / 12;

double finalIncome = deposit + periodInMonths * monthIncome;

// Output
Console.WriteLine(finalIncome);
// Input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

// Calculations
string typeHoliday = "";
string where = "";
double price = 0;

if (budget <= 100)
{
    where = "Bulgaria";
    if (season == "summer") price = 0.3 * budget;      //30% от бюджета
    else if (season == "winter") price = 0.7 * budget; //70% от бюджета
}
else if (budget > 100 && budget <= 1000)
{
    where = "Balkans";
    if (season == "summer") price = 0.4 * budget;      //40% от бюджета
    else if (season == "winter") price = 0.8 * budget; //80% от бюджета
}
else
{
    where = "Europe";
    price = 0.9 * budget; //90% от бюджета
}

// Определяне на типа почивка след определяне на дестинацията
if (where == "Europe")
{
    typeHoliday = "Hotel";
}
else
{
    if (season == "summer")
    {
        typeHoliday = "Camp";
    }
    else if (season == "winter")
    {
        typeHoliday = "Hotel";
    }
}

// Output
Console.WriteLine($"Somewhere in {where}");
Console.WriteLine($"{typeHoliday} - {price:F2}");

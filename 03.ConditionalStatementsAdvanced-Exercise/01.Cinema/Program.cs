// Input
string typeTicket = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

// Calculations
//•	Premiere – 12.00 лева.
//•	Normal – 7.50 лева.
//•	Discount – 5.00 лева.

int allSeats = rows * columns;
double priceForOneTicket = 0;

switch (typeTicket)
{
    case "Premiere": priceForOneTicket = 12; break;
    case "Normal": priceForOneTicket = 7.50; break;
    case "Discount": priceForOneTicket = 5; break;
}

double finalPrice = allSeats * priceForOneTicket;

// Output
Console.WriteLine($"{finalPrice:F2} leva");

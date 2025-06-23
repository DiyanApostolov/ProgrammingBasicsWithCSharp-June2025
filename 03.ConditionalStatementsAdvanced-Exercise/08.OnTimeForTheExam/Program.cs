// Input
int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int arriveHour = int.Parse(Console.ReadLine());
int arriveMinutes = int.Parse(Console.ReadLine());

// Calculations
int examTotalMinutes = examHour * 60 + examMinutes;       // 9:30 -> 570 minutes
int arriveTotalMInutes = arriveHour * 60 + arriveMinutes; // 10:20 -> 620 minutes

int diff = examTotalMinutes - arriveTotalMInutes;

if (diff < 0)
{
    // Late
    int minutesTotalLate = Math.Abs(diff); // diff is negative here
    int hoursLate = minutesTotalLate / 60;
    int minutesLate = minutesTotalLate % 60;

    Console.WriteLine("Late");

    if (hoursLate == 0)
        Console.WriteLine($"{minutesLate} minutes after the start");
    else
        Console.WriteLine($"{hoursLate}:{minutesLate:D2} hours after the start");
}
else if (diff >= 0 && diff <= 30)
{
    // On time or Early with minutes
    Console.WriteLine("On time");

    if (diff > 0)
        Console.WriteLine($"{diff} minutes before the start");
}
else if (diff > 30)
{
    // Early
    Console.WriteLine("Early");

    int hoursEarly = diff / 60;
    int minutesEarly = diff % 60;

    if (hoursEarly == 0)
        Console.WriteLine($"{diff} minutes before the start");
    else
        Console.WriteLine($"{hoursEarly}:{minutesEarly:D2} hours before the start");
}
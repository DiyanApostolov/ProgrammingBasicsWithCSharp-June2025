﻿// Input
int firstAthleteTime = int.Parse(Console.ReadLine());
int secondAthleteTime = int.Parse(Console.ReadLine());
int thirdAthleteTime = int.Parse(Console.ReadLine());

// Calculations
int sumOfAllTimes = firstAthleteTime + secondAthleteTime + thirdAthleteTime;

int minutes = sumOfAllTimes / 60;
int seconds = sumOfAllTimes % 60;

// Output
if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}


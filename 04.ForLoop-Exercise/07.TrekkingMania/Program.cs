
int countOfGroups = int.Parse(Console.ReadLine());

int musalaClimbers = 0;
int monblanClimbers = 0;
int kilimandzharoClimbers = 0;
int k2Climbers = 0;
int everestClimbers = 0;

for (int i = 1; i <= countOfGroups; i++)
{
    int countOfParticipants = int.Parse(Console.ReadLine());

    if (countOfParticipants >= 1 && countOfParticipants <= 5)
    {
        musalaClimbers += countOfParticipants;
    }
    else if (countOfParticipants >= 6 && countOfParticipants <= 12)
    {
        monblanClimbers += countOfParticipants;
    }
    else if (countOfParticipants >= 13 && countOfParticipants <= 25)
    {
        kilimandzharoClimbers += countOfParticipants;
    }
    else if (countOfParticipants >= 26 && countOfParticipants <= 40)
    {
        k2Climbers += countOfParticipants;
    }
    else if (countOfParticipants >= 41)
    {
        everestClimbers += countOfParticipants;
    }
}

double allClimbers = musalaClimbers + monblanClimbers + kilimandzharoClimbers + k2Climbers + everestClimbers;

double percentMusalaClimbers = musalaClimbers / allClimbers * 100;
double percentMonblanClimbers = monblanClimbers / allClimbers * 100;
double percentKilimandzharoClimbers = kilimandzharoClimbers / allClimbers * 100;
double percentK2Climbers = k2Climbers / allClimbers * 100;
double percentEverestClimbers = everestClimbers / allClimbers * 100;

Console.WriteLine($"{percentMusalaClimbers:f2}%");
Console.WriteLine($"{percentMonblanClimbers:f2}%");
Console.WriteLine($"{percentKilimandzharoClimbers:f2}%");
Console.WriteLine($"{percentK2Climbers:f2}%");
Console.WriteLine($"{percentEverestClimbers:f2}%");
        
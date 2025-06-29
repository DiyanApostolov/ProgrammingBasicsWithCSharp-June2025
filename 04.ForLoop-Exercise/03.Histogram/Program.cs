
int countOfNumbers = int.Parse(Console.ReadLine());

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;

for (int i = 0; i < countOfNumbers; i++)
{
    int currNum = int.Parse(Console.ReadLine());

    if (currNum < 200)
        p1++;
    else if (currNum <= 399)
        p2++;
    else if (currNum <= 599)
        p3++;
    else if (currNum <= 799)
        p4++;
    else if (currNum >= 800)
        p5++;
}

double percentP1 = (double)p1 / countOfNumbers * 100;
double percentP2 = (double)p2 / countOfNumbers * 100;
double percentP3 = (double)p3 / countOfNumbers * 100;
double percentP4 = (double)p4 / countOfNumbers * 100;
double percentP5 = (double)p5 / countOfNumbers * 100;

Console.WriteLine($"{percentP1:F2}%");
Console.WriteLine($"{percentP2:F2}%");
Console.WriteLine($"{percentP3:F2}%");
Console.WriteLine($"{percentP4:F2}%");
Console.WriteLine($"{percentP5:F2}%");


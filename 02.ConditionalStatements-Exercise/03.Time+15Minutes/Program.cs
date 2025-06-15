
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += 15;  // добавям 15 минути

if (minutes >= 60)
{
    minutes -= 60; // изваждаме 60 минути
    hours += 1;    // прибавяме един час
}

if (hours == 24)
{
    hours = 0;
}

if (minutes < 10)
    Console.WriteLine($"{hours}:0{minutes}");
else
    Console.WriteLine($"{hours}:{minutes}");
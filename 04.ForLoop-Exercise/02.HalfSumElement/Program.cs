
int n = int.Parse(Console.ReadLine());

int sumOfAllNumbers = 0;
int maxNumber = int.MinValue;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    sumOfAllNumbers += currentNumber;

    if (currentNumber > maxNumber)
    {
        maxNumber = currentNumber;
    }
}

int sum = sumOfAllNumbers - maxNumber;

if (sum == maxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    int diff = Math.Abs(sum - maxNumber);

    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");
}


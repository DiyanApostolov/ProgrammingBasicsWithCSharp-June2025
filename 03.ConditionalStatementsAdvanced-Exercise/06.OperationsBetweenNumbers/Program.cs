// Input
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

// Calculations
switch (operation)
{
    case '+' or '-' or '*':

        int result = 0;

        if (operation == '+')
        {
            result = n1 + n2;
            Console.Write($"{n1} + {n2} = {result}");
        }
        else if (operation == '-')
        {
            result = n1 - n2;
            Console.Write($"{n1} - {n2} = {result}");
        }
        else if (operation == '*')
        {
            result = n1 * n2;
            Console.Write($"{n1} * {n2} = {result}");
        }

        if (result % 2 == 0)
        {
            Console.Write(" - even");
        }
        else
        {
            Console.Write(" - odd");
        }

        break;
    case '/':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            double divide = (double)n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {divide:F2}");
        }
        break;
    case '%':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            double moduleDivide = n1 % n2;
            Console.WriteLine($"{n1} % {n2} = {moduleDivide}");
        }
        break;
}

int maxCountOfPoorGrades = int.Parse(Console.ReadLine());

double allGrades = 0;
int countOfProblems = 0;
string lastProblemName = "";
int poorGradesCounter = 0;

string problemName = Console.ReadLine();

while (problemName != "Enough")
{
    int currentGrade = int.Parse(Console.ReadLine());

    if (currentGrade <= 4)
    {
        poorGradesCounter++;

        if (poorGradesCounter == maxCountOfPoorGrades)
        {
            break;
        }
    }

    allGrades += currentGrade;
    countOfProblems++;

    lastProblemName = problemName;
    problemName = Console.ReadLine();
}

if (poorGradesCounter == maxCountOfPoorGrades)
{
    Console.WriteLine($"You need a break, {poorGradesCounter} poor grades.");
}
else
{
    double averageGrade = allGrades / countOfProblems;

    Console.WriteLine($"Average score: {averageGrade:F2}");
    Console.WriteLine($"Number of problems: {countOfProblems}");
    Console.WriteLine($"Last problem: {lastProblemName}");
}
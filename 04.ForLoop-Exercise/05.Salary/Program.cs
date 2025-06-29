
int countOfTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//•	"Facebook"-> 150 лв.
//•	"Instagram"-> 100 лв.
//•	"Reddit"-> 50 лв.

for (int i = 0; i < countOfTabs; i++)
{
    string tabTitle = Console.ReadLine();

    if (tabTitle == "Facebook")  
        salary -= 150;
    else if (tabTitle == "Instagram")  
        salary -= 100;
    else if (tabTitle == "Reddit") 
        salary -= 50;

    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}

if (salary > 0)
{
    Console.WriteLine(salary);
}
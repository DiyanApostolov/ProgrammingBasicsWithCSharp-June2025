
// *** mathematical approach ***

//int start = int.Parse(Console.ReadLine());
//int end = int.Parse(Console.ReadLine());

//int lastDigitStart = start % 10;
//int thirdDigitStar = start / 10 % 10;
//int secondDigitStart = start / 100 % 10;
//int fisrtDigitStart = start / 1000;

//int lastDigitEnd = end % 10;
//int thirdDigitEnd = end / 10 % 10;
//int secondDigitEnd = end / 100 % 10;
//int fisrtDigitEnd = end / 1000;


// *** string approach ***

string start = Console.ReadLine();
string end = Console.ReadLine();

int lastDigitStart = int.Parse(start[3].ToString());
int thirdDigitStar = int.Parse(start[2].ToString());
int secondDigitStart = int.Parse(start[1].ToString());
int fisrtDigitStart = int.Parse(start[0].ToString());

int lastDigitEnd = int.Parse(end[3].ToString());
int thirdDigitEnd = int.Parse(end[2].ToString());
int secondDigitEnd = int.Parse(end[1].ToString());
int fisrtDigitEnd = int.Parse(end[0].ToString());

for (int i = fisrtDigitStart; i <= fisrtDigitEnd; i++)
{
	for (int j = secondDigitStart; j <= secondDigitEnd; j++)
	{
		for (int k = thirdDigitStar; k <= thirdDigitEnd; k++)
		{
			for (int l = lastDigitStart; l <= lastDigitEnd; l++)
			{
				if (i % 2 != 0
					&& j % 2 != 0
					&& k % 2 != 0
					&& l % 2 != 0) // if all iterators are odd numbers -> print
				{
					Console.Write($"{i}{j}{k}{l} ");
				}
			}
		}
	}
}



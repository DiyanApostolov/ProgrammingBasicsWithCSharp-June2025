
string favoriteBook = Console.ReadLine();

int bookCounter = 0;

string bookName = Console.ReadLine();

while (bookName != "No More Books")
{
    if (bookName == favoriteBook)
    {
        Console.WriteLine($"You checked {bookCounter} books and found it.");
        break;
    }

    bookCounter++;

    bookName = Console.ReadLine();
}

if (bookName == "No More Books")
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {bookCounter} books.");
}

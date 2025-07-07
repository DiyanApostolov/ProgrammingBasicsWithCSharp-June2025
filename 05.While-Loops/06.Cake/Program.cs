
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int cakePieces = width * length;
    
string input = Console.ReadLine();

while (input != "STOP")
{
    int currentPieces = int.Parse(input);
    cakePieces -= currentPieces;

    if (cakePieces < 0)
        break;

    input = Console.ReadLine();
}

if (cakePieces >= 0)
{
    Console.WriteLine($"{cakePieces} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
}
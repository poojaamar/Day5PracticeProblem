int numOftimes = 10;
int heads = 0; 
int tails = 0;
double headsPercentage, tailsPercentage;

for (int i = 0; i < numOftimes; i++)
{
    Random random = new Random();
    int coinFlip = random.Next(0, 2);
    if (coinFlip < 0.5)
    {
        Console.WriteLine("Its Tails");
        tails++;
    }
    else
    {
        Console.WriteLine("Its Heads");
        heads++;
    }
}
headsPercentage = 100 * heads / numOftimes;
tailsPercentage = 100 * tails / numOftimes;
Console.WriteLine("Heads % : " + headsPercentage + " vs Tails % : " + tailsPercentage);

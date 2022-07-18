char ah;
Console.WriteLine("Enter the letter:");
ah = Char.Parse(Console.ReadLine());
if ((ah == 'a') || (ah == 'e') || (ah == 'i') || (ah == 'o') || (ah == 'u') || (ah == 'A') || (ah == 'E') || (ah == 'I') || (ah == 'O') || (ah == 'U'))
{
    Console.WriteLine(ah + " is a Vowel.");
}
else
{
    Console.WriteLine(ah + " is a Consonant.");
}
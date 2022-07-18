Console.WriteLine("Enter the Dividend && Divisor ");
int dividend = int.Parse(Console.ReadLine());
int divisor = int.Parse(Console.ReadLine());
int remainder;
double quotient;
quotient = dividend / divisor;
remainder = dividend % divisor;
Console.WriteLine("Remainder: " + remainder +  " Quotient: " + quotient);

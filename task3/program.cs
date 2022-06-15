System.Console.Write("enter number: ");
string x = Console.ReadLine();
int a = int.Parse(x);
if (a < 100) System.Console.WriteLine("no third number");
else
while (a > 999)
{
    a = a / 10;
}
System.Console.WriteLine($"{a%10}");
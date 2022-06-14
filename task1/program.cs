System.Console.Write("введите трехзначное число: ");
string x = Console.ReadLine();
int a = int.Parse(x);
int b = a % 100 / 10;
if (a > 99 && a < 1000) System.Console.WriteLine($"{b}");
if (a < 99 || a > 1000) System.Console.WriteLine("wrong number");  
    
       

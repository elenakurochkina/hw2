int a = new Random().Next(100,999);
System.Console.WriteLine(a);
int b = a / 100;
int c = a % 100 % 10;
System.Console.WriteLine($"{b},{c}");

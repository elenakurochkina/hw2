//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

int prompt(string message) 
{ 
System.Console.Write(message); 
string x = Console.ReadLine();
int a = int.Parse(x);
return a;
} 
int a = prompt("enter number from 1 till 7: ");
if (a == 1) System.Console.WriteLine("Monday - does not weekend");
if (a == 2) System.Console.WriteLine("Tuesday - does not weekend");
if (a == 3) System.Console.WriteLine("Wednesday - does not weekend");
if (a == 4) System.Console.WriteLine("Thursday - does not weekend");
if (a == 5) System.Console.WriteLine("Fryday - does not weekend");
if (a == 6) System.Console.WriteLine("Satterday - weekend");
if (a == 7) System.Console.WriteLine("Sunday - weekend");
if (a > 7 || a < 1) System.Console.WriteLine("wrong number");

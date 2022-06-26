// Задача 1

Console.Write("Введите число: a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: b ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
  Console.WriteLine("Max = " + a);  
}

else 
{
    Console.WriteLine("Max = " + b);    
}

// Задача 2

Console.Write("Введите число: a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: c ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > a)
{
  max = b;   
}
if (c > max)
{
  max = c;  
}
Console.WriteLine("Max = " + max);

//Задача 3

Console.Write("Введите число: a ");
int a = Convert.ToInt32(Console.ReadLine());


if (a % 2 == 0)
{
  Console.WriteLine("Четное");
}
else 
{
  Console.WriteLine("Нечетное");
}

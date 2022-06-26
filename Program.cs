// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 

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

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

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

//Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

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

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: a ");
int a = Convert.ToInt32(Console.ReadLine());
int min = 1; 

while (min <= a)
{
    if (min % 2 == 0)
Console.WriteLine(min + " ");
min ++;
}
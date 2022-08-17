/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введи число ");
string? a = Console.ReadLine();
int i = 0;
for (; a.Length > i; )
{
    i++;
}
Console.WriteLine(i);
int[] num = new int [i];
Console.WriteLine(num.Length);

for (int n = 0; i <= num.Length;)
{
   n = 12;
   num[0] = n;
   i--;
   Console.WriteLine(i);
}



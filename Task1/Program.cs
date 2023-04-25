// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
double chislo = Convert.ToInt32(Console.ReadLine());
double x = chislo/10; 
double x1 = Math.Floor(x); 
x = x/10; 
x = Math.Floor(x);
int i=0;
while (x < x1)
{
   x = x + 1;
   i++;
}
Console.WriteLine($"{chislo} - > {i}");
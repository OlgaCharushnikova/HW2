// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите чило: ");
double chislo = Convert.ToInt32(Console.ReadLine());

if (chislo>99) 
{
    int x = 0;
    int y = 1;
    int i = 1;
    while (x < chislo)
    {
        x = x+1; // x будет прибавляться на 1, пока не будет равно введенному числу
        if(x == y*10) // когда x будет равен 10, значит число двухзначное, 100, то число трехзначное и.т.д.
        {
            i++; // показывает сколькизначное число
            y=y*10; //как только y стал двузначным, нужно сделать,чтобы он был трехзначным
        }
    }
    double delitel1 = Math.Pow(10, i-2);
    double chislo1 = chislo/delitel1;
    chislo1 = Math.Floor(chislo1);
    chislo1 = chislo1*10;

    double delitel2 = Math.Pow(10, i-3);
    double chislo2 = chislo/delitel2;
    chislo2 = Math.Floor(chislo2);

    int j = 0;
    while (chislo2>chislo1)
    {
        chislo1 = chislo1 + 1;
        j++;
    }

Console.WriteLine($"{chislo} - > {j}");
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int count = a;
int GetSum(int a)
{
    int x = 0;
    while(a>0)
    {
        x++;
        a/=10;
    }

    return x;
} 
Console.WriteLine("Количество цифр равно"+" "+GetSum(a));


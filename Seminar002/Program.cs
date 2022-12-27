// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNum(int num)
{
int second = num / 10 % 10;
return second;
}

Console.WriteLine("Данный алгоритм принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа");
Console.Write("Введите трехзначное число:");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра Вашего числа: {SecondNum(second)}");

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNum(int num)
{
    while(num >= 1000)
    {
        num= num/10;
    }
    
    return num % 10;
    
}

Console.WriteLine("Данный алгоритм выводит третью цифру заданного Вами числа");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 != 0) Console.WriteLine($"Третья цифра введенного числа: {ThirdNum(number)}");
else Console.Write("Третьей цифры введенного числа не существует.");
*/


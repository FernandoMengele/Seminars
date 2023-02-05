// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* 
double GetNum (double num, int pow){
    double powRes = 1;
    for (int i = 1; i <= Math.Abs(pow); i++)
        powRes *= num;
    return powRes;
}
Console.Write("Input a number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a power: ");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetNum(numA, pow));
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumNumber (int num){
    int current = 0;
    while (num != 0){
        num = num / 10;
        current++;
    }
    return current;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumber(num));
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] GetMassive(int length)
{
    var array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Input a number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void GiveMassive(int[] array)
{
    Console.Write("You are array is [ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}
Console.Write("Please input array length: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = GetMassive(length);
GiveMassive(array);
*/
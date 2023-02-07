
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumNum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) sum++;
    }
    return sum;
}

Console.Write("Input value array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value possible: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[] myArr = CreateRandomArray(length, minVal, maxVal);
ShowArray(myArr);
int sumN = SumNum(myArr);
Console.WriteLine($"В массиве существует {sumN} четных чисел.");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
/*
[-4, -6, 89, 6] -> 0
int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void ArrayToConsole(int[] array)
{
    Console.Write("Your array is [");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}
int CountSumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}
Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array minValue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array maxValue ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(length, minValue, maxValue);
ArrayToConsole(newArray);
int res = CountSumOddIndex(newArray);
Console.WriteLine($"The sum of all numbers at odd position in array is {res} ");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
/*
double[] CreateRandomDoubleArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return array;
}
void DoubleArrayToConsole(double[] array)
{
    Console.Write("Your array is [");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

double MaxMinDif(double[] array)
{
    double max = array[0], min = array[0] ;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] >= max) max = array[i];
        else if(array[i]<=min) min = array[i];
    }
    return max - min;
}


Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array minValue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array maxValue ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomDoubleArray(length, minValue, maxValue);
DoubleArrayToConsole(newArray);

Console.WriteLine($"The difference between Max and Min value in array is {MaxMinDif(newArray)} ");
*/
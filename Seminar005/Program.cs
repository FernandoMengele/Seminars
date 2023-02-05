/*
int GetSum (int num)
{
    int sum = 0;
    for (int current = 0; current <= num; current++)
        sum += current;
    return sum;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSum(a));
*/
// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
/*
int GetComp (int num){
    int Factorial = 1;
    for (int current = 1; current <= num; current++)
        Factorial *= current;
    return Factorial;
}

Console.Write("Input anumber: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetComp(a));
*/
//Напишите программу, которая приимает на вход число и выдает количество цифр в числе.
/*
int Numbers (int n){
    int count = 0;
    while (n != 0){
        n = n / 10;
        count++;
    }
    return count;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(a));
*/

//-----------------[MASSIVES]-----------------
/*
int[] CreateRandomArray(int size, int minValue, int maxValue){
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
}
Console.Write("input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
*/

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
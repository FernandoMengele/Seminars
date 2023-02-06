// Необхогдимо написать программу, которая определяет сумму отрицательных элементов массива
/* 
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
*/
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
*/
/*
int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0) sum += array[i];
        }
    return sum;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possiple value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possiple value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);

int result = GetSumOfNegatives(newArray);
Console.WriteLine("Sum of negatives in this array is " + result);
*/
// Необходимо написать программу, заменяющее положительные элементы массива отрицательными и наоборот
/*
int[] CreateRandomArray (int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowMeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] ConvertArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

Console.Write("Input length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value a posible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value a posible: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomArray(length, min, max);
ShowMeArray(arr);
int[] newArr = ConvertArray(arr);
ShowMeArray(newArr);
*/
// Необходимо написать программу, определяющую, присутствует ли заданное число в массиве

int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool FindNumber(int[] array, int fnum)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == fnum) return true;  
    }
    return false;
}
Console.Write("Input length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value a posible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value a posible: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the desired number: ");
int fnum = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomArray(length, min, max);
ShowArray(arr);
bool yesno = FindNumber(arr, fnum);
if(yesno == true) Console.WriteLine("Yes!");
else Console.WriteLine("No");
// Необходимо задать массив из N элементов и определить количество элементов, пренадлежащих отрезку от A до B ()
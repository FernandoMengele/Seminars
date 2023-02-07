// Развернуть массив поэлементно
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

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input value array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value possible: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, minVal, maxVal);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

// Неободимо написать программу, которая принимает 3 числа и сообщает, может ли существовать треугольник с такими сторонами.
/*
bool Existence(int num1, int num2, int num3)
{
    return(num1 + num2 > num3) && (num2 + num3 > num1) && (num3 + num1 > num2);
}

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if(Existence(n1, n2, n3)) Console.WriteLine("Может");
else Console.WriteLine("Не может");
*/

// Необходимо написать программу, не используя рекурсию, необходимо вывести первую N чисел Фибаначи, где первая двойка чисел это A и B.
// (Каждое новое число происходит от суммы двух предыдущих элементов ряда) (На входе не 2 нуля, должно быть 2 элемента для начала ряда чисел)
// Сформировать массив
/*
double[] CreateArray(int length, int num1, int num2)
{
    double[] array = new double[length];
    array[0] = num1;
    array[1] = num2;
    for(int i = 2; i < length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input a numberA: ");
int nA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numberB: ");
int nB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int nN = Convert.ToInt32(Console.ReadLine());

double[] myArr = CreateArray(nN, nA, nB);
ShowArray(myArr);
*/
// Напишите программу, которая создает копию массива с помощью поэлементного массива
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

int[] CopyArray(int[] array)
{
    int[] copyArr = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr;
}

Console.Write("Input value array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value possible: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, minVal, maxVal);
ShowArray(myArray);
int[] copyArray = CopyArray(myArray);
ShowArray(copyArray);
*/
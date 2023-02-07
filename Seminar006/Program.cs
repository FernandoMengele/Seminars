// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3  <<<----- В условии либо ошибка, либо упущен знак минуса перед первой единицей
/*
Console.Write("Введите количество чисел, которые Вы хотите внедрить в программу: ");
int size = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int current = 0;
while(current < size)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0) sum++;
    current++;
}
Console.WriteLine($"Количество чисел больше нуля: {sum}");
*/
// Не знаю, нужен ли был метод в данной программе, но вот с методом:
/*
int SumOfPositiveNumbers(int size)
{
    int sum = 0;
    for(int c = 0; c < size; c++)
    {
        Console.Write("Введите число: ");
        if(Convert.ToInt32(Console.ReadLine()) > 0) sum++;
    }
    return sum;
}
Console.Write("Введите количество чисел, которые Вы хотите внедрить в программу: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество чисел больше нуля: {SumOfPositiveNumbers(size)}");
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
double[] LinesCrossing(double k1, double b1, double k2, double b2)
{
    double[] cross = new double[2];
    cross[0] = (b2 - b1) / (k1 - k2);
    cross[1] = k1 * cross[0] + b1;
    return cross;
}
void DoubleArrayToConsole(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}
Console.WriteLine("Заполните две функции, описывающие линии в координатах X,Y y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 != k2)
{
    Console.Write("Ваши прямые пересекаются в координатах [X,Y]: ");
    DoubleArrayToConsole(LinesCrossing(k1, b1, k2, b2));
}
else if(b1 != b2) Console.WriteLine("Ваши прямые не пересекаются");
else Console.WriteLine("Ваши прямые лежат на одной плоскости");
*/
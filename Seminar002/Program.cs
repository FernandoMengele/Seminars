/* 

int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result; // обязательно возвращаем, если не void
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of a number {randNumber} is {newNumber}");

*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*

int LargerNumber(int num)
{
   
    int num1 = num / 10;
    int num2 = num % 10;
    if(num1 > num2) return num1;
    return num2;
}

int randomnum = new Random().Next(10, 100);
Console.WriteLine($"Random number is {randomnum} LargerNumber {LargerNumber(randomnum)}");

*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.


/*
bool Mult(int num1, int num2)
{
    if(num1 % num2 == 0) return true;
    return false;
}
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Mult(num1, num2));

*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Mult(int num1, int num2)
{
    if(num1 * num1 == num2 || num2 * num2 == num1) return true;
    return false;
}
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Mult(num1, num2));

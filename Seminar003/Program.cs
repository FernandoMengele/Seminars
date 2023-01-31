// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrome (long number){
    long testNum = number, mirrorNum = 0;
    while (testNum != 0){
        mirrorNum = mirrorNum * 10 + testNum % 10;
        testNum = testNum / 10;
    }
    return mirrorNum == number;
}

Console.Write("Please input number: ");
long num = Convert.ToInt32(Console.ReadLine());

if (Palindrome(num)) Console.WriteLine("Yes, it is palindrome!");
else Console.WriteLine("No.");
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double DistanseAB (double x1, double y1, double z1, double x2, double y2, double z2){
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}

Console.Write("Input x1: ");
double xPos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
double yPos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
double zPos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
double xPos2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
double yPos2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
double zPos2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DistanseAB(xPos1, yPos1, zPos1, xPos2, yPos2, zPos2));
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Funct(int n){
    int count = 1;
    while (count <= n){
        double z = Math.Pow(count, 3);
        Console.WriteLine(z);
        count++;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Funct(num);
*/
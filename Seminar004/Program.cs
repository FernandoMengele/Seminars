//необходимо написать программу, которая по заданному числу четверти покажет диапазон возможных точек координат этой четверти
/*
void GetDiapazone (int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);

*/

// Задача 1

/*
int GetFunct(int xPos, int yPos)
{
    if(xPos > 0 && yPos > 0) return 1;
    else if (xPos < 0 && yPos > 0) return 2;
    else if (xPos < 0 && yPos < 0) return 3;
    else if (xPos > 0 && yPos < 0) return 4;
    else return 0;
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetFunct(x,y));
*/

// Задача 2. Напишите программу, которая принимает на вход число N и выводит таблицу квадратов до числа N
/*
void Funct(int n)
{
    int count = 1;
    while (count <= n)
    {
        int z = count + count;
        Console.WriteLine(z);
        count++;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Funct(num);
*/
// Найти расстояние между точками

double Funct(double xPos1, double yPos1, double xPos2, double yPos2)
{
    return Math.Sqrt(Math.Pow(xPos1 - xPos2, 2) + Math.Pow(yPos1 - yPos2, 2));
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Funct(x1,y1,x2,y2));
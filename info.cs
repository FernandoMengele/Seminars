int a = 5; // int только целые числа 32bit 
double b = 23.6; // double целые и дробные числа (вещественные)

bool c = true; // bool only true or false
string d = "World 222 !@#$"; // string строка, любые символы
char e = 'd'; //char символ в единственном числе. d, b, 1, 4...

Console.WriteLine("Good enening!"); // WriteLine and ReadLine - only string
Console.WriteLine("My number is" + a); // сложение строк, конкатинация

Console.WriteLine("My number is" + a + "and" + b + "ant it's good!"); // сложение строк, конкатинация

Console.WriteLine($"My number is {a} and {b} and it's good!"); // при добавлении "$" можно вводить все в одну строку. ($ - знак форматирования)

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine()); // проводится операция присваиваивания, после чего ReadLine конвертируется в string, ToInt32 - вес переменной int

// Условные операторы
if(num1 == quad2) // ";" в конце не ставим
{
    Console.WriteLine("YES!!!"); // обратить внимание на отступы
}
else
{
    Console.WriteLine("NO!!!");
}

// Если команда в условном операторе только одна, можно записать так:
if(num1 == quad2) Console.WriteLine("YES!!!"); // в этом случае ";" ставить в конце обязательно
else Console.WriteLine("NO!!!");

// Цикл
while(current <= number)
{
    Console.Write(current + " ");
    current = current + 1;  // current += 1; current++;
}

/*

32254 / 10 = 3225
32254 / 100 = 322
32254 / 1000 = 32
32254 / 10000 = 3

32254 % 10 = 4
32254 % 100 = 54
32254 % 1000 = 254
32254 % 10000 = 2254

*/

// Методы--------------
/*
[модификаторы] тип_возвращаемого_значения Название_метода ([параметры])
{
   тело метода 
}
*/


int LargerNumber(int num) // вызываем функцию LargerNumber(randomnum)
{
   
    int num1 = num / 10;
    int num2 = num % 10;
    if(num1 > num2) return num1;
    return num2;
}

int randomnum = new Random().Next(10, 100);
Console.WriteLine($"Random number is {randomnum} LargerNumber {LargerNumber(randomnum)}");

bool NewNumber2 ()
{
    int a = 1;
    if(a > 0) return true;
    return false; // либо true либо false
}

int a = 5;
if(a > 0 && a % 2 == 0) // && - и, || - или
{

}

bool Mult(int num1, int num2) // bool метод пример
{
    if(num1 * num1 == num2 || num2 * num2 == num1) return true;
    return false;
}

// double
Math.Pow(a,b) = a в степени b // возведение в степень
Math.Sqrt(a) = кв. корень a // извлечение КВАДРАТНОГО корня
Math.Round(a,b) // округление числа
// 0,12346789 где a = все числа после запятой, b = кол-во знаков, которые требуются

 if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0"); // каскадная проверка

// если будет пудключаться переменная, использующаяся только в цикле, то for
for(int current = 1; current <= num; current++)
        sum += current; 
//for([инициализация временной переменной]; [условие цикла]; [изменение временной переменной(current++ и тд)])

//---------------[MASSIVE]--------------------
int[] CreateRandomArray(int lenght, int minValue, int maxValue){ // Целочисленный массив, инициализация переменных под размер и пределы генерации
// при работе с массивами всегда for
    for(int i = 0; i < size; i++){ //int i = 0, size / 2 и так далее
        array[i] = new Random().Next(minValue, maxValue + 1); // maxValue + 1 потому что выставляется диапазон максимального размера - 1 изначально
    }
    return array; // при возвращении массива array пишется без обозначения массива []!!!!
}
// метод для ввода элементов массива вручную
void ShowArray(int[] array)
{
    for(int i = 0; i < array.legth; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
// !!!!! размер массива всегда int
// методы бывают генерирующими, аналитическими, преобразующими
// ПРИ РАБОТЕ С МАССИВАМИ ВЫДЕЛЯЕТСЯ ПАМЯТЬ ТОЛЬКО ПОД ОДИН МАССИВ, все остальные действия производятся
// только с этим массивом, вызов ссылки и присваивание другой ссылки только ссылается на этот массив
//_______bool_____
//буливый метод может быть реализован либо через if либо сразу можно писать в result неравенства. 
// Если условия выполнятся, автоматически даст true и наоборот
bool Existence(int num1, int num2, int num3)
{
    return(num1 + num2 > num3) && (num2 + num3 > num1) && (num3 + num1 > num2);
}
if(Existence(n1, n2, n3)) Console.WriteLine("Может");
else Console.WriteLine("Не может");
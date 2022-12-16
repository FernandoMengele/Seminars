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

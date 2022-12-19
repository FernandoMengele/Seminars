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


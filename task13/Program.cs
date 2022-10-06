/* 
Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int getTheDigit(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder);
    return result;
}

int getTheThirdDigitFromNumber(int number)
{
    int currentDigit = new int();
        if (9999 < number)
        {
            currentDigit = number / 100;
        }
        else if (999 < number && 10000 > number)
        {
            currentDigit = number / 10;
        }
        else if (number < 100)
        {
        Console.WriteLine("Третьей цифры нет");
        }
        else if (number > 100 && number < 1000)
        {
        currentDigit = number;
        }
    int thirdDigits = currentDigit % 10;
    return thirdDigits;
}

int RandomNumber = getTheDigit(0, 100000);
Console.WriteLine($"Заданное число {RandomNumber}");
int thirdDigit = getTheThirdDigitFromNumber (RandomNumber);
Console.WriteLine($"У числа {RandomNumber} третья цифра {thirdDigit}");
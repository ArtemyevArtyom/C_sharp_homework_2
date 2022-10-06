/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int getTheDayOfWeek(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder);
    return result;
}

int checkTheDayOfWeek(int number)
{
    if(number > 5) 
    {
            Console.WriteLine("Да, выходной");
            return(number);
    }
    else 
    {
        Console.WriteLine("Не выходной");
        return(number);
    }
}

int theWeekDay = getTheDayOfWeek(1, 8);
int Weekend = checkTheDayOfWeek(theWeekDay);
Console.WriteLine($"День недели: {theWeekDay}");
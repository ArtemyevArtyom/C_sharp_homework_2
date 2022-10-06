/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(100, 1000);

int getSecondDigit(int number)
{
    int firstNumber = number / 10;
    int secondNumber = firstNumber % 10;
    return (secondNumber);
}

Console.WriteLine(number);
int result = getSecondDigit(number);
Console.WriteLine(result);
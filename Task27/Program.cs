/*Задача 27: Напишите программу, которая принимает на вход
число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

using static System.Console;
FindSumOfDigits(Input("N"));



int Input(string Temp)
{
    Write($"Введите натуральное число {Temp}: ");
    return int.Parse(ReadLine()!);
}


void FindSumOfDigits(int temp)
{
    int sumOfDigits = 0;
    while (temp > 0)
    {
        sumOfDigits += temp % 10;
        temp /= 10;
    }
    WriteLine(sumOfDigits);
}






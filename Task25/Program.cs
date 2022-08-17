/*Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A в 
натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

using static System.Console;
numberToPowAnother(Input("A"), Input("B"));



int Input(string Temp)
{
    Write($"Введите число {Temp}: ");
    return int.Parse(ReadLine()!);
}


void numberToPowAnother(int temp1, int temp2)
{
    int mult = 1;
    for (int i = 0; i < temp2; i++) mult *= temp1;
    WriteLine(mult);
}
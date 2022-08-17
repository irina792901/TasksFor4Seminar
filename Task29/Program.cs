/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

using static System.Console;
Clear();
WriteRandomMassiv(Input("размер"), Input("нижнюю границу"), Input("верхнюю границу"));



int Input(string Temp)
{
    Write($"Введите {Temp} рандомного массива: ");
    return int.Parse(ReadLine()!);
}



void WriteRandomMassiv(int sizeOfRandomMassiv, int lowerBorder, int upperBorder)
{
    int[] Massiv = new int[sizeOfRandomMassiv];
    for (int i = 0; i < sizeOfRandomMassiv; i++)
    {
        Massiv[i] = new Random().Next(lowerBorder, upperBorder + 1);
    }
    WriteLine($"[{String.Join(", ", Massiv)}]");
}

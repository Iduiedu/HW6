// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
using System;
class workhome
{
    public static void Main()
    {
        task35();
    }
public static void task35()
    {
        int[] mas = new int[123];
        int[] itog = new int[123];
        Random rnd = new Random();
        int count = 0;
        for (int i = 0; i < 123; i++)
        {
            mas[i] = rnd.Next(0, 1000);
            if (mas[i] > 10 && mas[i] < 99)
            {
                itog[count] = mas[i];
                count++;
            }
        }
        Console.WriteLine("Количество {0}", count);
    }
}
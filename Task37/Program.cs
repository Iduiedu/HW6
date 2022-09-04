// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

using System;
class workhome
{
    public static void Main()
    {
        task37();
    }
        public static void task37()
    {
        Console.Write("Введите размер массива = ");
        int raz = Convert.ToInt16(Console.ReadLine());
        int[] mas = new int[raz];
        int razitog = raz % 2 == 0 ? raz / 2 : raz / 2 + 1;
        int[] itog = new int[razitog];
        Random rnd = new Random();
        for (int i = 0; i < raz; i++)
        {
            mas[i] = rnd.Next(0, 10);
        }
        for (int i = 0; i < raz / 2; i++)
        {
            itog[i] = mas[i] * mas[raz - i - 1];
        }
        if (raz % 2 != 0)
        {
            itog[razitog - 1] = mas[razitog - 1];
        }
        Console.WriteLine("[{0}]-> [{1}] ", string.Join(",", mas), string.Join(",", itog));
    }
}
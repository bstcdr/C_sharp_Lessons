﻿//Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
using Common;

int[] array = new int[5] { 1, 2, 3, 4, 5 };

int[] reverse = Reverse2(array);
ArrayCommon.PrintArray(reverse);


void Reverse(int[] array)
{
    int tmp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}

int[] Reverse2(int[] array)
{
    int[] reverse = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reverse[i] = array[array.Length - 1 - i];
    }
    return reverse;
}

﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[4] {"Hello", "мир", "789", "день"};
string[] Newarray = new string[array.Length];
int a = 0;
for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        { 
           Newarray[a] = array[i];
           a++;
        }
    }
PrintArray(Newarray);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
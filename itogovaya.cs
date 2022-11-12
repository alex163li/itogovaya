﻿int size = 6;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите набор символов, означающих значение строкового элемента массива, {size} раз через enter, без пробелов");
FillArray(arrayOne);
Console.Clear();
PrintArray(arrayOne);

void FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray (string[] arr)
{
    Concole.Write ("[ ");
    for (int i = 0; i < size; i++)
    {
        Concole.Write (arr[i] + " ");
    }
    Concole.Write ("]");
}
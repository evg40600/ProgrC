﻿// Task36
// Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); 
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);

int sum = 0;

for (int i = 1; i < n; i = i + 2)
{
    sum = sum + array[i];
}    

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Сумма = {sum}");

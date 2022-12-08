// Задача 34
// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [-9, 9]
}

Console.Clear();

int[] array = new int[900];
int col = 0;

InputArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
        col++;
}

Console.WriteLine(col);

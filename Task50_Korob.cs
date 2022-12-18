// Задача 50
// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[, ] matrix, int x, int y)
{
    if (x >= matrix.GetLength(0) 
        || y >= matrix.GetLength(1) 
        || x < 0 || y < 0)
        Console.WriteLine("К сожалению, Вы ошиблись в координатах");
    else
        Console.WriteLine(matrix[x, y]);
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] razmer = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[razmer[0], razmer[1]];

InputMatrix(matrix);

Console.Write("Введите позицию элемента ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

ReleaseMatrix(matrix, coord[0] - 1, coord[1] - 1);
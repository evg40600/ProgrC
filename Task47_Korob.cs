// task 47
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами

void InputMatrix(double [, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble();
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] razmer = Console.ReadLine().Split(" ");
int n_row = int.Parse(razmer[0]);
int n_column = int.Parse(razmer[1]);

double[,] matrix = new double[n_row, n_column];

InputMatrix(matrix);
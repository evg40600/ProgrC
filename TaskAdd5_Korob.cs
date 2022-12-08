// Задача про английский язык

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32); 
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);

int[] array_NeChet = new int[n];
int[] array_Chet = new int[n];
int col_chet = 0;
int col_nechet = 0;

for (int i = 0; i < n; i++)
{
    if (array[i]%2 == 0)
    {
        array_Chet[col_chet]=array[i];
        col_chet++;
    }    
    else
    {
        array_NeChet[col_nechet]=array[i];
        col_nechet++;
    }    
}

Console.WriteLine($"Массив нечётных: [{string.Join(", ", array_NeChet)}]");
Console.WriteLine($"Массив чётных: [{string.Join(", ", array_Chet)}]");
if (col_nechet > col_chet)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
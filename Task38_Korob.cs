// Task38
// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101); 
}

Console.Clear();

Console.WriteLine("Укажите размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);

int mmin = array[0];
int mmax = mmin;

for (int i = 1; i < n; i++)
{
    if (array[i] > mmax)
        mmax = array[i];
    else if (array[i] < mmin)
        mmin = array[i];
}    

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Разница максимального и минимального значения = {mmax - mmin}");

// Напишите программу, которая задаёт массив из 8 элементов, 
// запрашивает данные(элементы массива) у пользователя и 
// выводит их на экран.

Console.Clear();

int[] array = new int[8]; 

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");
Console.WriteLine("Ваш массив");
Console.WriteLine(String.Join(", ", array));
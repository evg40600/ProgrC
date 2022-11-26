Console.Clear();
Console.WriteLine("Введите свою последовательность цифр:");
int n = Convert.ToInt32(Console.ReadLine()); //вводим первое число
int max1 = n; // максимум1 и максимум2 пока равны первому числу
int max2 = n;

n = Convert.ToInt32(Console.ReadLine()); //вводим второе число (по условиям задачи будет минимум 2 числа до нуля)
if (n>max1)
{
    max1 = n;
}
else
{
    max2 = n;
}
//теперь можно запускать цикл
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n != 0)
    {
        if (n > max1)
        {
            max2 = max1;
            max1 = n;
        }
        else
        {
            max2 = n;
        }
    }          
    // обновили значения максимума и можно ждать следующую цифру
    
}
Console.WriteLine($"Второе максимальное число:{max2}");
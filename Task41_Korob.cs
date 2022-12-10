// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Clear();
Console.WriteLine("Укажите сколько будет чисел:");
int M = Convert.ToInt32(Console.ReadLine());

int col = 0;

Console.WriteLine("Вводите числа:");

for (int i = 0; i < M; i++)
{
    if (Convert.ToInt32(Console.ReadLine()) > 0)
        col++;
}
Console.WriteLine($"Вы ввели {col} чисел/числа больше 0");
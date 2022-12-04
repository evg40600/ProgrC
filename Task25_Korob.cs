// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ Math.Pow

Console.Clear();
Console.WriteLine("Введите числo A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числo B:");
int B = Convert.ToInt32(Console.ReadLine());
int res = 1;

for (int i = 1; i <= B; i++)
{
    res = res * A;
}

Console.WriteLine($"{A}^{B} = {res}");

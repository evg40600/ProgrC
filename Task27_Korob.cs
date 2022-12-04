// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе

Console.Clear();
Console.WriteLine("Введите числo:");
String A = Console.ReadLine();

int len = A.Length;
int summa = 0;

for (int i = 0; i < A.Length; i++)
    summa = summa + (Convert.ToInt32(A[i])-48); //потому что символ "1" имеет код 49

Console.WriteLine($"Сумма чисел: {summa}");

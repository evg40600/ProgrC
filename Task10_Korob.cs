Console.Clear();
Console.WriteLine("Введите своё трёхзначное число");
int aaa = Convert.ToInt32(Console.ReadLine());
int aa = aaa/10;
int a = aa % 10;
Console.Write($"Вторая цифра: {a}");

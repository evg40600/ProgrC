Console.Clear();
Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());

int n5 = n % 10;
int n4 = ((n % 100) / 10);
int n2 = ((n % 10000) / 1000);
int n1 = ((n % 100000) / 10000);

if (n1 == n5 && n2 == n4)
    Console.WriteLine("Это палиндром");
else
    Console.WriteLine("Это просто число");

Console.Clear();
Console.WriteLine("Введите своё трёхзначное число");
string n_str = Console.ReadLine();
int n_len = n_str.Length;
//Console.WriteLine(n_len);
if (n_len<3) 
{
    Console.WriteLine("В числе нет третьей цифры");
}
else 
{
    int n = Convert.ToInt32(n_str);
    for (int i = 3; i<n_len; i++)
        n = n / 10;
    Console.WriteLine($"Третья цифра: {n % 10}");
}
Console.Clear();
Console.WriteLine("Введите количество кустов");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество черники на кустах");
int [] a = new int[N];
for (int i=0; i<N; i++)
    a[i] = Convert.ToInt32(Console.ReadLine());

// сначала надо проверить, что кустов больше 3. Если меньше, то можно сразу просуммировать
int sum = a[0] + a[1] + a[2];

if (N>3)
{
//теперь надо проверить крайние кусты
    if (a[0]+a[1]+a[N-1]>sum)
        sum=a[0]+a[1]+a[N-1];
    if (a[0]+a[N-1]+a[N-2]>sum)
        sum=a[0]+a[N-1]+a[N-2];
// теперь можно перебрать весь массив

    for (int j=1;j<(N-1);j++)
    {
        if (a[j]+a[j-1]+a[j+1]>sum)
            sum=a[j]+a[j-1]+a[j+1];
    }
}

Console.WriteLine($"Максимальная сумма черники: {sum}");
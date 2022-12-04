// суперсдвиг

void Zapolnenie_Array (int N, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void Sdvig_vlevo (int[] array)
{
    int a_temp = array[0];
    for (int i=0;i<array.Length-1;i++)
    {
        array[i]=array[i+1];
    }
    array[array.Length-1]=a_temp;
}

void Sdvig_vpravo (int[] array)
{
    int a_temp = array[array.Length-1];
    for (int i=array.Length-1;i>0;i--)
    {
        array[i]=array[i-1];
    }
    array[0]=a_temp;
}

void Print_Array (int[] array)
{
        Console.WriteLine(" ");
        Console.WriteLine("Ваш массив:");
        Console.WriteLine(String.Join(", ", array));
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива N:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N]; 

Zapolnenie_Array(N, array);

Console.WriteLine("Введите сдвиг К:");
int K = Convert.ToInt32(Console.ReadLine());

if (K>0)
{
    for (int i=0; i<K; i++)
        Sdvig_vlevo(array);
    Print_Array(array);
}
else if (K<0)
{
    for (int i=K; i<0; i++)
        Sdvig_vpravo(array);
    Print_Array(array);
}
else if (K==0)
{
    Print_Array(array);
}


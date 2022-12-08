// поиск простых слагаемых

int Prostoe (int n)
{
    if (n <= 3) return 1; //если простое, то возвращаем 1, иначе 0 
    else 
    {
        for (int i = 2; i <= n/2; i++) //достаточно проверить до половины числа
        {
            if (n%i==0) 
            {   
                return 0;
                break;
            }    
        }    
        return 1;
    }
}    

Console.Clear();
Console.WriteLine("Введите числo:");
int x = Convert.ToInt32(Console.ReadLine());

for (int j = 2; j <= x/2; j++)
{
    if (Prostoe(j) == 1)
    {
        if (Prostoe(x-j) == 1)
        {
            Console.WriteLine($"Число {x} состоит из простых слагаемых {j} и {x-j}");
            break;
        }    
    }
}
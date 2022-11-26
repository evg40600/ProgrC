Console.Clear();
Console.WriteLine("Введите день недели");
int d = Convert.ToInt32(Console.ReadLine());
if (d<8)
{
    if (d == 6 || d == 7)
    {
        Console.WriteLine("Это выходной");
    } 
    else
    {
        Console.WriteLine("Это будни");
    } 
}
else
{
    Console.WriteLine("Вы ввели число больше 7");
} 

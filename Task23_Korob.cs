Console.Clear();
Console.WriteLine("Введите числo:");
int x = Convert.ToInt32(Console.ReadLine());

for (int i=1;i<x;i++)
    Console.WriteLine(i*i*i);
   
Console.WriteLine(x*x*x);
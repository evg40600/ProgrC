Console.Clear();
Console.WriteLine("Введите координаты точки А (xyz):");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B (xyz):");
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());

Double rast = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2));
Console.Write($"Расстояние между точками:{Math.Round(rast,2)}");

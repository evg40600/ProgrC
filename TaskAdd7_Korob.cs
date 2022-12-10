// Площадь треугольника
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=116&id_problem=719
int Modul(int a, int b)
{
    if (a>=b)
        return (a-b);
    else
        return (b-a);    
}

double Ploshad (int x_1, int y_1, int x_2, int y_2, int x_3, int y_3)
{
    double S;
    S = 0.5*Modul(x_1, x_3) * Modul(y_2, y_3) - Modul(x_2, x_3)*Modul(y_1, y_3);
    return S;
}

Console.Clear();
Console.WriteLine("Введите координаты первой вершины. X и Y:");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй вершины. X и Y:");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты третьей вершины. X и Y:");
int x3 = Convert.ToInt32(Console.ReadLine());
int y3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Площадь треугольника составляет: {Ploshad(x1,y1,x2,y2,x3,y3)}");

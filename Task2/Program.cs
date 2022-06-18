Console.WriteLine("Введите координату х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

void coordinates(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int sum = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1);
    double root = Convert.ToDouble(Math.Sqrt(sum));
    double root1 = Math.Round(root, 2);
    Console.WriteLine(root1);

}

coordinates(x1, y1, z1, x2, y2, z2);
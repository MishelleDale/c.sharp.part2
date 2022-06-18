Console.WriteLine("Найдем все кубы от 1 до N");
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

void cubes (int N)
{
    for (int i = 1; i <= N; i++)
    {
        int cube = i*i*i;
        Console.Write(cube);
        if (i < N) Console.Write(", ");
    }
}

cubes(N);
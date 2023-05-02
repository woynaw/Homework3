void Cube(int arg)
{
    int count = 1;
    while (count <= arg)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }

}
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{n} -> ");
Cube(n);
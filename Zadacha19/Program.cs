bool Check(int arg)
{
    if (arg > 9999 && arg < 100000) return true;
    else
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
}
bool IsPal(int arg)
{
    int temp = arg;
    int sum = 0;
    int digit = 0;
    while (arg != 0)
    {
        digit = arg % 10;
        sum = sum * 10 + digit;
        arg = arg / 10;
    }
    if (temp == sum) return true;
    else return false;
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (Check(num)) {
    Console.WriteLine(IsPal(num));
}
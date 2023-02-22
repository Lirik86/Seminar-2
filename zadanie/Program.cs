int promt(string msg)
{
    System.Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

bool validate(int num)
{
    if (num >= 100 && num < 1000)
    {
        return true;
    }
    Console.WriteLine("ввели не верное число");
    return false;
}

int value = promt("Введите 3-х значное число >");
if (validate(value))
{
    int last = value % 10;
    Console.WriteLine($"третий знак равен {last}");
}
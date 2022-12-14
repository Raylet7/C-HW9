// Программа, определяющая сумму натуральных элементов от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
bool IsIncorrectInput(int number)
{
    return number < 1;
}
int GetNaturalNumberSum(int m, int n)
{
    if (m == n) return m;
    if (m > n)
    {
        int temporary = m;
        m = n;
        n = temporary;
    }
    if (m < n) return m + GetNaturalNumberSum(m + 1, n);
    return 0;
}
Console.WriteLine();
Console.WriteLine("Программа определения суммы натуральных элементов от M до N.");
Console.WriteLine();
InputM:
Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(m))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputM;
}
Console.WriteLine();
InputN:
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(n))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputN;
}
Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {GetNaturalNumberSum(m, n)}");
Console.WriteLine();
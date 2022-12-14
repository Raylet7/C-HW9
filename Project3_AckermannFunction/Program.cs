// Программа, вычисляющая функцию Аккермана для двух неотрицательных чисел m и n
// (с помощью рекурсии). 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
bool IsIncorrectInput(int number)
{
    return number < 0;
}
int AckermannFunction(int m, int n)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}
Console.WriteLine();
Console.WriteLine("Программа вычисления функции Аккермана для двух неотрицательных чисел m и n.");
Console.WriteLine();
InputM:
Console.Write("Введите неотрицательное число m: ");
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
Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(n))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputN;
}
Console.WriteLine();
Console.WriteLine($"Результат вычисления функции Аккермана равен: A({m},{n}) = {AckermannFunction(m, n)}");
Console.WriteLine();
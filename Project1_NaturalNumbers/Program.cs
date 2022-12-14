// Программа, выводящая все натуральные числа от N до 1
// (с помощью рекурсии).
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
bool IsIncorrectInput(int n)
{
    return n < 1;
}
void PrintNaturalNumbers(int n)
{
    if (n == 1) Console.Write($"{n}");
    else
    {
        Console.Write($"{n}, ");
        PrintNaturalNumbers(n - 1);
    }
}
Console.WriteLine();
Console.WriteLine("Программа вывода всех натуральных чисел от заданного числа N до 1.");
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
Console.WriteLine("Все натуральные числа от N до 1:");
PrintNaturalNumbers(n);
Console.WriteLine();
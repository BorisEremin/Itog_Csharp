// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// M = 2, N = 3 -> A(m,n) = 9
// M = 3, N = 2 -> A(m,n) = 29

int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");

int functionAkkerman = Akk(m, n);

Console.Write($"A(M, N) = {functionAkkerman} ");

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
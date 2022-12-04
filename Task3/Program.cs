// Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
// 2,3 -> 8, 27
// 1,5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

int count = n;

while (count >= n && count <= m)
{
    Console.Write($"{count * count * count}, ");
    count++;
}
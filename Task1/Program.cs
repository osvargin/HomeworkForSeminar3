// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number < 100000)
    {
    int division1 = (number / 10000);
    int remainder1 = (number % 10);
    int division2 = (number / 1000) % 10;
    int remainder2 = (number / 10 % 10);
    if (division1 == remainder1 && division2 == remainder2) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
    }
else 
    {
    Console.WriteLine("Некорректное число!");
    }

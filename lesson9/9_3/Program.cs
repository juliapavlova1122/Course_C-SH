﻿// Задача 3: Напишите программу, которая 
// будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

// Console.WriteLine ("Введите число: ");
// int a = int.Parse (Console.ReadLine());

// int sum = 0;
// while (a > 0)
// {
//     sum+= a%10;
//     a/= 10;
// }
// Console.WriteLine (sum);

int sumnums (int sum)
{
    if (sum == 0) return 0;
    return sumnums(sum/10) + sum% 10;
}


Console.WriteLine (sumnums (123));

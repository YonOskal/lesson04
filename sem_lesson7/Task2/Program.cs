﻿// Напишите программу, которая будет принимать на
// вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumDigit (int n)
{
if(n == 0) return 0;
return n % 10 + SumDigit(n / 10); // Cначала выполняется рекурсия
}

Console.WriteLine(SumDigit(63));
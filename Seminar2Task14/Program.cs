﻿// Задача №14
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и
// 23.
// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

int num = int.Parse(Console.ReadLine()??"0");
if(num%7 ==0 && num%23 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("NO");
}


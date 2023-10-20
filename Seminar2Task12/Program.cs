// Задача №12
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе
// число кратным первому. Если второе число
// некратно первому, то программа выводит остаток от
// деления.
// Например:
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно 
// Console.WriteLine("Hello, World!");

int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
if(numB%numA == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("некратно " + numB%numA);
}



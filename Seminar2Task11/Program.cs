// Задача №11
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98 

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int firstDigit = num/100;
// int secondDigit = num%10;
// num = firstDigit*10 + secondDigit;
// Console.WriteLine(num);

int ran = new System.Random().Next(100, 1000);
System.Console.WriteLine(ran);
char[] digitChar = ran.ToString().ToCharArray();
System.Console.Write(digitChar[0]);
System.Console.Write(" ");
System.Console.Write(digitChar[2]);








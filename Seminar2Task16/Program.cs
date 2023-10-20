// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого.
// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет 

// int numA = int.Parse(Console.ReadLine() ?? "0");
// int numB = int.Parse(Console.ReadLine() ?? "0");

// bool test1 = (numA == numB * numB);
// bool test2 = (numB == numA * numA);

// if(test1) Console.WriteLine("квадрат второго");
// if(test2) Console.WriteLine("квадрат первого");
// if(!(test1||test2))
// {
//     Console.WriteLine("не квадраты друг другу");
// }

int GetNUm()
{
    Console.Write("please enter number ");
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

int num1 = GetNUm();
int num2 = GetNUm();

bool num1Pow = num1 == Math.Pow(num2, 2);
bool num2Pow = num2 == Math.Pow(num1, 2);

Console.WriteLine(num1Pow || num2Pow ? "является квадратом" : "не явлеятся квадратом");

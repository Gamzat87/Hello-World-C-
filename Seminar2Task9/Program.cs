// Задача №9
// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


void Variant2()
{
    Console.WriteLine("OPtion 2");
    // рандомайзер, кладет новые числа
    System.Random numberGenerator1 = new System.Random();
    // кладем число 
    int num1 = numberGenerator1.Next(10, 100);
    Console.WriteLine(num1);

    Console.WriteLine((num1 / 10 > num1 % 10) ? (int)(num1 / 10) : (int)
    (num1 % 10));
}

void Variant1()
{
    Console.WriteLine("OPtion 1");
    // рандомайзер, кладет новые числа
    System.Random numberGenerator = new System.Random();
    // кладем число 
    int num = numberGenerator.Next(10, 100);
    Console.WriteLine(num);
    // берем 2 переменные 
    int firstDigit = num / 10; // 34/10 = 3 
    int secondDigit = num % 10; // остаток от деления 34%10 = 4 

    // сравниваем числа 
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void Variant3()
{
    Console.WriteLine("OPtion 3");
    // рандомайзер, кладет новые числа
    System.Random numberGenerator1 = new System.Random();
    // кладем число 
    int num3 = numberGenerator1.Next(10, 100);
    Console.WriteLine(num3);

    char[] digitChar = num3.ToString().ToCharArray();
    Console.WriteLine((int) digitChar[0]> (int) digitChar[1]? digitChar[0]: digitChar[1]);
    // <стоит условие> стоит? если условие верно выполняется вариант 1: если не верно то варинат 2

}

Variant1();
Variant2();
Variant3();

// Задача №0
// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя).

Console.WriteLine("Please enter number");
// считаем данные с консоли 
string? inputNum = Console.ReadLine();
 // ??"0";
// проверям, чтобы данные были не пустыми
if(inputNum!=null)
{
    //парсим выделенное число 
    int num = int.Parse(inputNum);
    // находим квадрат числа
    int result = num*num;
    // выводим данные в косоль
    Console.WriteLine(result);

}
Console.WriteLine("квадрат числа: "+(int)Math.Pow(int.Parse(inputNum),2));
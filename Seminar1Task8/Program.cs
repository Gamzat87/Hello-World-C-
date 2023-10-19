// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

// Console.WriteLine("Please enter a number: ");
// // прием данных
// int N = int.Parse(Console.ReadLine());
// // создания счетчика 
// int count = 0;

// // проверка на четность
// if(N%2 == 0)
// {
//     while(count< N) 
//     {
//         // увелечение и вывод счетчика 
//         count = count +2;
//     Console.Write(count+" ");
//     }

// }
// else
// {
//     // делаем число четным
//     N = N - 1;
//     while(count < N)
//     {
//         // увелечение и вывод счетчика 
//         count = count + 2;
//         Console.Write(count+" ");
//     }
// }

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Кол-во элементов > 0: {count}");

// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());
 
 
// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;
 
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");



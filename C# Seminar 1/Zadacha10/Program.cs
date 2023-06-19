// посчитаем сумму всех целых чисел от 1 до N, где N вводит пользователь

// int Summa(int num)
// {
//     int sum = 0;
//     while (true)
//     {
//         sum+=num;
//         num--;
//          if (num==0)
//         break;
//     }
//     return sum;
// }

// int SummaRec(int num)
// {
//     if (num==0) return 0;
//     return num + SummaRec(num-1);
// }

// //SummaRec(4)
// //4 + (3 + (2 + (1 + 0)))


// Console.Clear();
// System.Console.WriteLine("Введите целое число ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех целых чисел от 1 до {num} равна {Summa(num)}");
// System.Console.WriteLine($"а если рекурсией то {SummaRec(num)}");



// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// string GetNumbers(int num)
// {
//     string str = "";
//      while (true)
//     {
//         str = Convert.ToString(num) + " " + str;
//         num--;
//         if (num==0)
//             break;
//     }
//     return str;
// }

// string GetNumbersRec(int num)
// {
//     if (num == 0)  return "";
//     return GetNumbersRec(num - 1) + num + " " ;    
// }

// Console.Clear();

// System.Console.WriteLine("Введите целое число ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetNumbersRec(num));



// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// string GetNumbers(int num, int num2)
// {
//     string Numbers = "";
//     while (true)
//     {
//         Numbers = num + " " + Numbers;
//         num--;
//         if (num==num2)
//             break;
//     }
//     return Numbers;
// }

// string GetNumbersRec(int num, int num2)
// {
//     if (num==num2)  return $"{num} ";
//     return GetNumbersRec(num - 1, num2) + num + " ";
// }




// Console.Clear();
// System.Console.WriteLine("Введите целое число начало: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите целое число конец: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Все натуральные от {num2} до {num} равна {GetNumbersRec(num, num2)}");



//  Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int Summa(int num)
// {
//     int sum = 0;
//     while (true)
//     {
//         sum += num % 10;
//         num /= 10;
//         if (num == 0)
//             break;
//     }
//     return sum;
// }

// int SummaRec(int num)
// {
//     if (num == 0)  return 0;
//     return num % 10 + SummaRec(num / 10);
// }

// Console.Clear();
// System.Console.WriteLine("Введите целое число ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех целых чисел от 1 до {num} равна {Summa(num)}");
// System.Console.WriteLine($"а если рекурсией то {SummaRec(num)}");



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Stepen(int num, int stepen)
// {
//     int sum = 1;
//     int count = 0;
//     while (true)
//     {
//         sum *= num;
//         count++;
//         if (count == stepen)
//             break;
//     }
//     return sum;
// }

// int StepenRec(int num, int stepen)
// {
//     if (stepen == 0) return 1;
//     return num * StepenRec(num, stepen-1);
// }

// Console.Clear();

// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите в какую степень будем его возводить");
// int stepen = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Stepen(num, stepen));
// System.Console.WriteLine(StepenRec(num, stepen));
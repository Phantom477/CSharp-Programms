// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1>num2) 
//     System.Console.WriteLine($"Максимальное число {num1}");
// else if (num1<num2)
//     System.Console.WriteLine($"Максимальное число {num2}");
 

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Clear();
// System.Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите третье число ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num2<num1 && num1>num3)
//     {
//         System.Console.WriteLine($"Максимальное число: {num1}");
//     }
// else if (num1<num2 && num2>num3)
// {
//     System.Console.WriteLine($"Максимальное число: {num2}");
// }
// else if (num1<num3 && num3>num2)
// {
//     System.Console.WriteLine($"Максимальное число: {num3}");
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%2==1)
//     System.Console.WriteLine("Нечетное");
// else
//     System.Console.WriteLine("Четное");



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for(int i=1;i<=num;i++)
// {
// if (i % 2 == 0)
// System.Console.Write(i+ " ");
// }


// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности и 
// на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));
// int ReadInt(string message)
// {
//  Console.Write(message);
//  return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
// int result = 0;
//  if (b < 3)
//     {
//  Console.Write("Пусто, выросла капуста: ");
//     }
//  else
//     {
//  int c = 1;
//  for (int i = b; i > 3; i--)
//         {
//  c = c * 10;
//         }

//  result = (a / c) % 10;
//     }
// return result;
// }

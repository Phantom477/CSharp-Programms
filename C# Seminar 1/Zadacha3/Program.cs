// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Console.Clear();
// int num = new Random().Next(10,100);
// System.Console.WriteLine($"было сгенерировано случайное число {num}");
// int x1 = num/10;
// int x2 = num%10;
// if (x1>x2)
//     System.Console.WriteLine($"наибольшая цифра этого числа это {x1}");
// else if (x1<x2)
//     System.Console.WriteLine($"наибольшая цифра этого числа это {x2}");
// else 
//     System.Console.WriteLine("Обе цифры этого числа равны");

// for (int i=1;i<=10;i++)
//     System.Console.WriteLine($"{i}");


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100,1000);
// System.Console.WriteLine($"было сгенерировано случайное число {num}");

// int x1=num/100;

// int x3=num%10;

// System.Console.WriteLine($"{x1}{x3}");


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Clear();
// System.Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1%num2 == 0)
//     System.Console.WriteLine("кратно");
// else 
//     System.Console.WriteLine($"не картно, остаток {num1%num2}");


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// System.Console.WriteLine("Enter number ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 7;
// int d = 23; 

// if (a%b == 0 && a%d == 0 )
//     System.Console.WriteLine("cratno");
// else 
//     System.Console.WriteLine( "ne cratno ");


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Clear();
// System.Console.WriteLine("Enter two numbers ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b * b || b == a * a) 
//     System.Console.WriteLine("yes");
// else 
//     System.Console.WriteLine("no");


// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
//123456 - >13456

// Console.Clear();
// System.Console.WriteLine("Enter number   ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (num / i != 0)
//     i *= 10;
// int x = num / (i / 10);
// int y = num % (i / 100);
// int result = (i / 100) * x + y;

// System.Console.WriteLine(result);


// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

// Console.Clear();
// System.Console.WriteLine("Enter number   ");
// double num = Convert.ToDouble(Console.ReadLine());
// if(num<10)
// {
//     System.Console.WriteLine("No");
// }
// double i = 1;
// while (num / i != 0)
//     i *= 10;
// double x = num / (i / 10);
// double y = num % (i / 100);
// double result = (i / 100) * x + y;

// System.Console.WriteLine(result); 
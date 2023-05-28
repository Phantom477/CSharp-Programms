// Задача 24: Напишите программу, которая принимает на вход число (А) и
//  выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Summa(int num)
// {
//     int result = 0;
//     for (int i=1;i<=num;i++)
//         result+=i;
//     return result;
// }

// Вариант с функцией void:
// void Summa2(int num)
// {
//     int result = 0;
//     for (int i=1;i<=num;i++)
//         result+=i;
//     System.Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");
// }

// Console.Clear();
// System.Console.WriteLine("Ввести натуральное число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма чисел от 1 до {num} равна {Summa(num)}");



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Log10(double d): возвращает десятичный логарифм числа d

// int numAmount (int num)
// {
//     int count = 0;
//     if (num==0) 
//     {
//         count = 1;
//         return count;
//     }

//     int result = (int)Math.Abs(num);
    
//     while (result > 1)
//     {
//         result = result / 10;
//         count ++;
//     }
//     return count;
// }

// Console.WriteLine("Введите число любой разрядности");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(numAmount(N));

// Посчитать количество всех цифр после запятой (не доделана)

// double numAmount (double num)
// {
//     int count = 0;
//     if (num==0) 
//     {
//         count = 1;
//         return count;
//     }

//     int result = (int)Math.Abs(num);
    
//     while (result > 1)
//     {
//         result = result / 10;
//         count ++;
//     }
//     return count;
// }

// Console.WriteLine("Введите число любой разрядности");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(numAmount(N));



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int fact (int N)
// {
//     int result = 1;
//     for (int i = 1; i <= N; i++)
//     result = result*i;
//     return result;
// }

// System.Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());


// System.Console.WriteLine(fact(N));



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void Array ( )
// {
//     int[] arrary=new int[8];
//     for (int i=0; i<8; i++)
//     arrary[i]=new Random().Next(0,2);
//     foreach (int item in arrary)
//     {
//     Console.Write(item);
//     }
// }
// Array();
    
// На ввод одна функция на вывод другая (не доделана)

// void FillArray ( )
// {
//     int[] arrary=new int[8];
//     for (int i=0; i<8; i++)
//     arrary[i]=new Random().Next(0,2);
//     foreach (int item in arrary)
//     {
//     Console.Write(item);
//     }
// }
// void check ()
// Array();
    
// функция буллевого типа и пишет находится ли в массиве больше нулей чем едениц

// void Arr(int[] Array)
// {
//     for (int i = 0; i<Array.Length; i++)
//     {
//          Array[i] = new Random().Next(0, 2);
//     }
// }

// bool OneZero(int[] Array)
// {
//     int count = 0;
//     for (int i = 0; i<Array.Length; i++)
//     {
//         if (Array[i] == 1)
//             count++;
//     }

//     bool flag = false;
//     if (count>Array.Length/2)
//         flag = true;
//     return flag;
// }


// Console.Clear();
// int[] Array = new int[8];
// Arr(Array);
// foreach (var i in Array)    
//     System.Console.Write(i+" ");


// System.Console.WriteLine(OneZero(Array));
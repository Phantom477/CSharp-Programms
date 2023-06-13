// Задача 46: Задайте двумерный массив размером rows×cols, заполненный 
//случайными целыми числами.
// rows = 3, cols = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(-30,31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j],3}    ");
//         System.Console.WriteLine();
//         }
// }


// Console.Clear();
// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);



// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = i+j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j],3}    ");
//         System.Console.WriteLine();
//         }
// }


// Console.Clear();
// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(-9,10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j],3}    ");
//         System.Console.WriteLine();
//         }
// }

// void ReplaceArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (i%2!=0 && j%2!=0)
//             {
//                 array[i,j] = array[i,j]*array[i,j];
//             }
// }



// Console.Clear();
// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// ReplaceArray(array);
// PrintArray(array);



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. И  
// найти отдельно сумму элементов обратной диагонали.
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12

// Сумма элементов обратной диагонали 8 + 9 + 7 = 24

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(-9,10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j],3}    ");
//         System.Console.WriteLine();
//         }
// }

// int[] TraceArray(int[,] array)
// {
//     int[] summ = {0, 0};
    
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//             if (i==j)
//             {
//                 summ[0] = summ[0] + array[i,j];
//             }
//             if (i == array.GetLength(1)-j-1)
//             {
//                 summ[1] = summ[1] + array[i,j];
//             }
//         }
//         }
//     return summ;
// }


// Console.Clear();
// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// int[] summ = TraceArray(array);
// System.Console.WriteLine($"{summ[0]}, {summ[1]}");


// Альтернативное решение:
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(-30,31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j],3}    ");
//         System.Console.WriteLine();
//         }
// }

// void PrintArray2(int[] array)
// {
//     foreach (var item in array)
//     {
//         System.Console.WriteLine($"{item} ");
//     }
// }

// int [] Sum (int[,] array)
// {
//     int [] sum = new int[2];
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum[0]+=array[i,i];
//             sum[1]+=array[i,array.GetLength(1)-i-1];
//         }
//     return sum;
// }

// Console.Clear();
// System.Console.WriteLine("Введите количество строк и столбцов: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Введите количество столбцов");
// int cols = rows;
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);

// PrintArray2(Sum(array));

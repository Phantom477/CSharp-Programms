// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

// void ChangeMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[0,i]; // здесь можно было сделать множетвенное присваивание
//         array[0,i] = array[array.GetLength(0)-1, i];
//         array[array.GetLength(0)-1, i] = temp;
//     }     
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
// ChangeMatrix(array);
// PrintArray(array);



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

// void Transponirovanie(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = i; j < array.GetLength(1); j++)
//     {
//         int temp = array[i,j]; // здесь можно было сделать множетвенное присваивание
//         array[i,j] = array[j, i];
//         array [j,i] = temp;

//     }     
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
// if (array.GetLength(0) == array.GetLength(1))
// {
//     Transponirovanie(array);
//     PrintArray(array);
// }
// else 
// {
//     System.Console.WriteLine("Матрица не квадратная");
// }



// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3}    ");
//         System.Console.WriteLine();
//     }
// }

// int[] Count(int[,] array)
// {
//     int[] arr = new int[10];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             arr[array[i, j]]++;
//     }
//     return arr;
// }

// Console.Clear();
// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// int[] arr = Count(array);

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i]>0)
//     Console.WriteLine($"{i} встречается {arr[i]} раз");
// }



// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

// Console.Clear();

// int rows = 4;
// int columns = 4;
// int min = -10;
// int max = 10;

// int[,] oldTable = GenerateTable(rows, columns, min, max);

// WriteTable(oldTable, "исходный массив");

// int [] minCoords = FindMin (oldTable);

// int [,] newTable = Remove(oldTable, minCoords[0], minCoords[1]);

// WriteTable(newTable, "результирующий массив");

// int [] FindMin (int[,] table){
//     int iMin = 0;
//     int jMin = 0;
//     int min = table[iMin, jMin];

//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             if (table[i, j] < min){
//                 min = table[i, j];
//                 iMin = i;
//                 jMin = j;
//             }
//         }
//     }
//     Console.WriteLine($"минимум: {min}");
//     Console.WriteLine($"координаты: {iMin} {jMin}");
//     return new int[] {iMin, jMin};
// }


// int[,] Remove (int [,] oldTable, int delRow, int delCol){
//     // а вот тут создаем массив на 1 меньше
//     int [,] newTable = new int [oldTable.GetLength(0) - 1, oldTable.GetLength(1) - 1];

//     // вот тут создаются
//      for (int i = 0, iNew = 0; i < oldTable.GetLength(0); i++)
//     {
//         // если удаляемая строка, то просто пропускаем
//         if (i == delCol) continue;
//         // и вот тут
//         for (int j = 0, jNew = 0; j < oldTable.GetLength(1); j++)
//         {
//             // если удаляемый столбец, то просто пропускаем
//             if (j == delCol) continue;
//             newTable[iNew, jNew] = oldTable[i, j];
//             // вот тут вручную приращиваем
//             jNew++;
//         }
//         // и тут
//         iNew++;
//     }

//     return newTable;
// }


// int[,] GenerateTable(int rows, int columns, int min, int max)
// {
//     int[,] table = new int [rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table [i,j] = rnd.Next(min, max);
//         }
//     }

//     return table;
// }


// void WriteTable (int [,] table, string? header){
//     if (header != null) Console.WriteLine(header);
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write("{0} ", table[i, j]);
//         }
//         Console.WriteLine();
//     }
// }
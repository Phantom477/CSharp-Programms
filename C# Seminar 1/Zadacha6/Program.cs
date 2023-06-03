// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// void FindSums(int[] array)
// {
//     int sumP=0;
//     int sumN=0;
//     foreach (var item in array)
//         if (item>0)
//             sumP+=item;
//         else
//             sumN+=item;
//     System.Console.WriteLine($"Сумма отрицательных элементов массива равна {sumN}");
//     System.Console.WriteLine($"Сумма положительных элементов массива равна {sumP}");
// }

// // Аналогичный вариант функции с int

// int[] FindSums2(int[] array)
// {
//     int sumP=0;
//     int sumN=0;
//     foreach (var item in array)
//         if (item>0)
//             sumP+=item;
//         else
//             sumN+=item;
//     int[] result = {sumN, sumP};
//     return result;
// }

// Console.Clear();
// System.Console.WriteLine("Введите размерность массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// FillArray(array);
// PrintArray(array);
// FindSums(array);
// PrintArray(FindSums2(array));



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// void ChangeArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
// }

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         System.Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }


// System.Console.Write("Введите диапазаон массива: ");
// int size = Convert.ToInt32(System.Console.ReadLine());

// int[] Array = new int[size];

// FillArray(Array);
// PrintArray(Array);
// ChangeArray(Array);
// PrintArray(Array);



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// void FindNumberInArray(int[] array, int num)
// {
//     bool Find = false;
//     foreach (var item in array)
//     {
//         if (item == num)
//         {
//             System.Console.WriteLine("Да");
//             Find = true;
//             break;
//         }
//     }
//     if (Find == false) System.Console.WriteLine("Нет");
// }

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         System.Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }


// System.Console.Write("Введите диапазаон массива: ");
// int size = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());

// int[] Array = new int[size];

// FillArray(Array);
// PrintArray(Array);
// FindNumberInArray(Array, num);



// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
// }



// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         System.Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// void FindArray(int[] array)
// {
//     int Count = 0;
//     foreach (var item in array)
//     {
//         if (item>=10 && item<=99)
//             Count++;
//     }
//     System.Console.WriteLine(Count);
// }


// int[] array = new int[15];
// FillArray(array);
// PrintArray(array);
// FindArray(array);



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// void FillArray(int[] array) 
// { 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         array[i] = new Random().Next(-100, 101); 
//     } 
// } 
 
 
 
// void PrintArray(int[] array) 
// { 
//     foreach (var item in array) 
//     { 
//         System.Console.Write($"{item} "); 
//     } 
//     System.Console.WriteLine(); 
// } 
 
 
 
// void ProizArray (int[] array, int[] arrayProiz) 
// { 
//     int size = array.Length/2; 
//     for (int i = 0; i < size; i++) 
//     { 
//         arrayProiz[i] = array[i] * array[array.Length-1-i]; 
//     } 
//     if (size%2==1) 
//         arrayProiz[arrayProiz.Length-1] = array[array.Length/2]; 
//     System.Console.WriteLine(); 
// } 
 
 
// Console.Clear(); 
// System.Console.Write("Введите диапазон массива: "); 
// int size = Convert.ToInt32(System.Console.ReadLine()); 
 
// int[] array = new int[size]; 
// int[] arrayProiz = new int[size/2 + size%2]; 
 
// FillArray(array); 
// PrintArray(array); 
// ProizArray(array, arrayProiz); 
// PrintArray(arrayProiz);
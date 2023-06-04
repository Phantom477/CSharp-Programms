// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

// void ReverseArray(int[] array)
// {
//     //int temp=0;
//     for (int i=0;i<array.Length/2;i++)
//     {
//         // temp = array[array.Length-1-i];
//         // array[array.Length-1-i] = array[i];
//         // array[i] = temp;
//         //(x,y) = (y,x);
//         (array[array.Length-1-i],array[i]  ) = (array[i] ,array[array.Length-1-i] );
//     }
// }


// Console.Clear();
// System.Console.WriteLine("Введите размерность массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// FillArray(array);    // заполнили массив
// PrintArray(array);   // показали пользователю что получилось
// ReverseArray(array); // перевернули массив
// PrintArray(array);   // и опять показали пользователю что получилось



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// bool SummaStoron(int num1, int num2, int num3)
// {
//     bool summa = false;
//     if (num1 < num2+num3 && num2 < num1+num3 && num3 < num1+num2)
//         summa = true;
//     else summa = false;
//     return summa;
// }

// Console.Clear();

// System.Console.WriteLine($"Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Введите число 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Может существовать такой треугольник: {SummaStoron(num1, num2, num3)}");



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// string Res(int N)
// {
//     string res = "";
//     while (N > 0)
//     {
//         res = Convert.ToString(N % 2) + res;
//         N = N / 2;
//     }
//     return res;
// }
// System.Console.WriteLine("Введите десятичное число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Res(N));



// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// void FillArray(int[] arr)
// {
//     arr[0] = 0;
//     arr[1] = 1;
//     arr[2] = 1;
//     for (int i = 3; i < arr.Length; i++)
//     {
//         arr[i] = (arr[i-1])+(arr[i-2]);
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


// Console.Clear();
// System.Console.WriteLine("Введите количество чисел Фибоначчи, которое хотите увидеть");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// FillArray(array);
// PrintArray(array);



// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


// void FillArray(int[] arr)
// {
//     arr[arr.Length/2] = 0;
//     arr[arr.Length/2+1] = 1;
//     arr[arr.Length/2-1] = 1;

//     for (int i = arr.Length/2+2; i < arr.Length; i++)
//     {
//         arr[i] = (arr[i-1])+(arr[i-2]);
//     }

//     for (int i = 0; i < arr.Length/2-1; i ++)
//     {
//         arr[i] = arr[arr.Length-1-i];
//         if (i%2==0) arr[i] = arr[i]*-1;
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



// Console.Clear();
// System.Console.WriteLine("Введите количество чисел Фибоначчи, которое хотите увидеть");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size*2-1];
// FillArray(array);
// PrintArray(array);
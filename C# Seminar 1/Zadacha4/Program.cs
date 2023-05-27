// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// Console.Clear();
// System.Console.WriteLine("Введем координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введем координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x>0 && y>0)
//     System.Console.WriteLine("Это четверть № 1");
// else if (x>0 && y<0)
//     System.Console.WriteLine("Это четверть № 4");
// else if (x<0 && y>0)
//     System.Console.WriteLine("Это четверть № 2");
// else if (x<0 && y<0)
//     System.Console.WriteLine("Это четверть № 3");
// else 
//     System.Console.WriteLine("Точка находится на координатной оси");



// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void CheckKoord(int x, int y)  //что-то делает но ничего не возвращает
// {
//     if (x > 0 && y > 0)
//         System.Console.WriteLine("Это четверть № 1");
//     else if (x > 0 && y < 0)
//         System.Console.WriteLine("Это четверть № 4");
//     else if (x < 0 && y > 0)
//         System.Console.WriteLine("Это четверть № 2");
//     else if (x < 0 && y < 0)
//         System.Console.WriteLine("Это четверть № 3");
//     else
//         System.Console.WriteLine("Точка находится на координатной оси");
// }

// int CheckKoord2(int x, int y)  //что-то делает и что-то возвращает
// {
//     int result = 0;
//     if (x > 0 && y > 0)
//         result = 1;
//     else if (x > 0 && y < 0)
//         result =  4;
//     else if (x < 0 && y > 0)
//         result = 2;
//     else if (x < 0 && y < 0)
//         result = 3;
//     return result;
// }



// Console.Clear();
// System.Console.WriteLine("Введем координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введем координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x,y);
// System.Console.WriteLine($"это четверть № {CheckKoord2(x,y)}");



// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void CheckQuarter(int num)
// {
//     switch(num)
//     {
//         case 1: 
//         {
//             System.Console.WriteLine("x > 0; y > 0");
//             break;
//         }
//         case 2: 
//         {
//             System.Console.WriteLine("x < 0; y > 0");
//             break;
//         }
//         case 3: 
//         {
//             System.Console.WriteLine("x < 0; y < 0");
//             break;
//         }
//         case 4: 
//         {
//             System.Console.WriteLine("x > 0; y < 0");
//             break;
//         }
//         default:
//         {
//             System.Console.WriteLine("Такой четверти нет!");
//             break;
//         }
//     }
// }


// System.Console.WriteLine("Введите четверть: ");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckQuarter(num);


// void CheckQuarter(int x) //Что то делает но ничего не возвращает
// {
//     if (x==1)
//         System.Console.WriteLine("X>0,Y>0");
//     else if (x==2)
//         System.Console.WriteLine("X<0,Y>0");
//     else if (x==3)
//         System.Console.WriteLine("X<0,Y<0");
//     else if (x==4)
//         System.Console.WriteLine("X>0,Y<0");
//     else
//         System.Console.WriteLine("Такой четверти нет");
// }


// Console.Clear();
// System.Console.WriteLine("Введите четверть");
// int x = Convert.ToInt32(Console.ReadLine());
// CheckQuarter(x);

// C защитой try catch
// void CheckQuarter(int x) //Что то делает но ничего не возвращает
// {
//     if (x==1)
//         System.Console.WriteLine("X>0,Y>0");
//     else if (x==2)
//         System.Console.WriteLine("X<0,Y>0");
//     else if (x==3)
//         System.Console.WriteLine("X<0,Y<0");
//     else if (x==4)
//         System.Console.WriteLine("X>0,Y<0");
//     else
//         System.Console.WriteLine("Такой четверти нет");
// }


// Console.Clear();
// System.Console.WriteLine("Введите четверть");
// try
// {
//     int x = Convert.ToInt32(Console.ReadLine());
// CheckQuarter(x);
// }
// catch
// {
//     System.Console.WriteLine("Надо было вводить целое число!");
// }



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// double Length(double A1, double A2, double B1, double B2)
// {
//     double result = Math.Sqrt((B1-A1)*(B1-A1) + (B2-A2)*(B2-A2));
//     return result;
// }

// System.Console.WriteLine("Введите первую координату точки А");
// double A1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите вторую координату А");
// double A2 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите первую координату точки В");
// double B1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите вторую координату точки В");
// double B2 = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"расстояние между точками составит {Length(A1, A2, B1, B2)}");



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Math.Sqrt())
// decimal CalculateDistance (int x1, int x2, int y1, int y2)
// {
// decimal distance = Math.Round(Convert.ToDecimal(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))), 2);
// return distance;
// }

// Console.Clear();
// System.Console.WriteLine("Введите координату Х1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату У1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Х2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату У2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CalculateDistance (x1, x2, y1, y2));
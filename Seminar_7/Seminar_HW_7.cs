
//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] CreateDouble(int rows, int cols, int min, int max){
//     double [,] array = new double [rows, cols];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < cols; j++){
//             array[i,j] = (new Random().NextDouble() * (max - min) + min);
//         }
//     }
//     return array;
// }

// void Show2dArray (double[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             System.Console.Write(Math.Round(array[i,j],2)+ "  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double [,] array = CreateDouble(m,n,min,max);
// System.Console.WriteLine();
// Show2dArray(array);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет.

// int [,] Create2dArray(int rows, int cols, int min, int max){
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < cols; j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Show2dArray (int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] FindPosition(int [,] array, int x, int y){

//     for (int i = 0; i < array.GetLength(0); i++){
//         if ((x > array.GetLength(0)) || (y > array.GetLength(1))){
//         Console.WriteLine($"Число с индексом {x}, {y} не существует");
//         break;
//         }else{
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i == x && j== y)
//             {
//                 Console.Write($"Ваше число: {array[i,j]}");
//             } 
//         }
//         }
//         Console.WriteLine();
//     }
//     return array;

    
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of x-rows elem: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of y-rols elem: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2dArray(m,n,min,max);
// Show2dArray(array);
// Console.WriteLine();
// FindPosition(array,x,y);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] CreateMidArray(int rows, int cols, int min, int max){
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < cols; j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void ShowMidArray (int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// double ArithMid(int [,] array){
// double sum = 0;
// double count = 0;
// double midsum = 0;
// double midsum0 = 0;
// double midsum1 = 0;
// double midsum2 = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if(j == 0){
//                 sum = sum + array[i,j];
//                 count++;
//                 midsum0 = sum/count;
//             }else if (j==1){
//                 sum = sum + array[i,j];
//                 count++;
//                 midsum1 = sum/count;
//             }else if (j==2){
//                 sum = sum + array[i,j];
//                 count++;
//                 midsum2 = sum/count;
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine($"{Math.Round(midsum0,2)}, {Math.Round(midsum1,2)}, {Math.Round(midsum2,2)}");
//     return midsum;
// }


// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateMidArray(m,n,min,max);
// ShowMidArray(array);
// Console.WriteLine();
// System.Console.WriteLine( Math.Round(ArithMid(array),2));

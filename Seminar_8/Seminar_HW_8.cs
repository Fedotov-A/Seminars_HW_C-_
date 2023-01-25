// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int [,] CreateRandom2dArray(int rows, int cols, int min, int max){
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

// int [,] DecreasArr(int[,] array){
//     int jmax=0;
//     int imax=0;
//     int maxD = array[imax,jmax];
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if(array[imax,j]>maxD){
//                 maxD = array[i,j];
//                 array[i,j] = array[imax,jmax];
//                 array[imax,jmax] = maxD;
//             }
//         }
//     }
//     for (int i = 1; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if(array[i,j]>maxD){
//                 maxD = array[i,j];
//                 array[i,j] = array[imax,jmax];
//                 array[imax,jmax] = maxD;
//             }
//         }
//     }
//     return array;
// }

// System.Console.WriteLine("Введите число строк массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение массива ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение массива ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreateRandom2dArray(m,n,min,max);
// System.Console.WriteLine("Исходный массив");
// Show2dArray(array);
// System.Console.WriteLine("Отсортированный массив");
// int [,] changeArray = DecreasArr(array);
// Show2dArray(changeArray);
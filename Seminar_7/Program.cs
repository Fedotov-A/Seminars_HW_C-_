//Example 1: Задайте двумерный массив размером mxn, заполненный случайными целыми числами.

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
//             System.Console.Write(array[i,j]+ " ");
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
// int [,] array = Create2dArray(m,n,min,max);
// Show2dArray(array);

//Example 2: задайте двумерный массив размера m на n.
//каждый элемент в массиве находится по формуле: A = m+n.
//Выведите полученный массив на экран.

// int [,] Create2dmn(int rows, int cols){
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < cols; j++){
//             array[i,j] = i + j;
//         }
//     }
//     return array;
// }

// void Show2dArray (int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             System.Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2dmn(m,n);
// Show2dArray(array);


//Example 3: задайте двумерный массив. Найдите элементы у которых оба индекса 
//четные, и замените эти элементы на их квадраты.
//например изначально массив выглядел вот так.
//1 4 7 2
//5 9 2 3
//8 4 2 4

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

// int [,] FindQuoters(int [,] array){

//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i%2==0 && j%2==0)
//             {
//                 array[i,j] = array[i,j] * array[i,j];
//                 Console.Write(array[i,j]+ " ");
//             }else{
//                 Console.Write(array[i,j]+ " ");
//             }
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

// int [,] array = Create2dArray(m,n,min,max);
// Show2dArray(array);
// Console.WriteLine();
// FindQuoters(array);

//Example 3: Задайте двумерный массив. Найдите сумму элементов находящихся, 
// на главной диагонали (0,0), (1,1) и т.д.

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

// int FindSum(int [,] array){
// int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i==j)
//             {
//                 sum = sum + array[i,j];
//             }
//         }
//     }
//     return sum;
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());

// if (m == 0 || n ==0)
// {
//     System.Console.WriteLine("Матрица не равна нулю!");
// }else
// {
//     int [,] array = Create2dArray(m,n,min,max);
// Show2dArray(array);
// Console.WriteLine();
// Console.WriteLine(FindSum(array));
// }


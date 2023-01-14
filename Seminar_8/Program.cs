//Example 1:Задайте двумерный массив. Напишите программу, которая поменяет местами 
//две любые строки массива.

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

// int [,] ChangeArrayRows(int [,] array){

//     Console.Write("Enter number of first row: ");
//     int row1 = Convert.ToInt32(Console.ReadLine()); 
//     Console.Write("Enter number of second row: ");
//     int row2 = Convert.ToInt32(Console.ReadLine()); 

//     if (row1 >=0 && row2 >= 0 && row1 < array.GetLength(0) && row2 < array.GetLength(0) && row1 != row2 )
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2,j];
//             array[row2,j] = temp;
//         }
//         return array;
//     }else{
//         System.Console.WriteLine("incorrect input");
//         ChangeArrayRows(array);
//         return array;
//     } 
// }

// int row = 4;
// int cols = 3;
// int min = 1;
// int max = 15;
// int [,] array = CreateRandom2dArray(row,cols,min,max);
// Show2dArray(array);
// int [,] changeArray = ChangeArrayRows(array);
// Show2dArray(changeArray);


//Example 2: Задайте двумерный массив. Напишите программу, которая 
//заменяет строки на столбцы. В случае если это невозможно, программа должна
//вывести сообщение для пользователя.

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

// int [,] ChangeArrayRows(int [,] array){

//     if (array.GetLength(0) == array.GetLength(1) && array.GetLength(1)>0 && array.GetLength(0)>0)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i+1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
//             }
    
//         }
//         return array;
//     }else{
//         System.Console.WriteLine("incorrect input");
//         return array;
//     } 
// }

// int row = 4;
// int cols = 4;
// int min = 1;
// int max = 15;
// int [,] array = CreateRandom2dArray(row,cols,min,max);
// Show2dArray(array);
// System.Console.WriteLine();
// int [,] changeArray = ChangeArrayRows(array);
// Show2dArray(changeArray);


//Задайте двумерный массив из целых чисел. напишите программу которая заменит
//значения строк и столюцов на нули, на пересечении которых расположен
//наименьший элемент массива.

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

// int [,] Change2Zero(int [,] array){
// int imin = 0;
// int jmin = 0;
    
//         for (int i = 0; i < array.GetLength(0); i++){
//             for (int j = 0; j < array.GetLength(1); j++){
//                 if(array[i,j]<array[imin,jmin]){
//                     jmin=j;
//                     imin=i;
//                 }
//             }
//         }
//         for (int i = 0; i < array.GetLength(0); i++){
//             for (int j = 0; j < array.GetLength(1); j++){
//                 array[i,jmin]=0;
//                 array[imin,j]=0;
//             }
//         }
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
// int [,] changeArray = Change2Zero(array);
// Show2dArray(changeArray);
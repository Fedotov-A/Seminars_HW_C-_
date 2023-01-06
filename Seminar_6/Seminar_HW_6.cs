//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


// int [] Array123(int num){
//     int [] array = new int [num];
//     for (int i = 0; i < num; i++)
//     {
//         Console.WriteLine("Введите число ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int [] array){
    
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($" {array[i]}");
//     }
//     Console.WriteLine();
// }

// int AboveZero(int [] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++){
//         if(array[i]>0){
//             count = count +1;
//         }
//     }
//     return count;
    
// }

// System.Console.WriteLine("Введите желаемое количество чисел: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int [] zero = Array123(num);
// ShowArray(zero);
// int res = AboveZero(zero);
// Console.WriteLine($"Количество чисел больше нуля:  {res}");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void Intersection(double b1, double k1, double b2, double k2){
//     double x = ((b2 - b1)/(k1 - k2));
//     double y1 = k1 * x + b1;
//     double y2 = k2 * x + b2;

//     Console.WriteLine($"Точка пересечения: ({y1}, {y2})");
// }

// Console.Write("Введите координату b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// Intersection (b1, k1, b2, k2 );
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] ThreeDigitArr(int num)
// {
//     int [] array = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int EvenNumber(int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count +=1;
            
//     }
//     return count;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int lengthArray = Convert.ToInt32(Console.ReadLine());
// int [] res = ThreeDigitArr(lengthArray);
// ShowArray(res);
// int value = EvenNumber(res);
// System.Console.WriteLine($"Количество четных чисел: {value}");

//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] Array123(int num)
// {
//     int [] array = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(1, 124);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int IntervalNumber(int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//             count +=1;
            
//     }
//     return count;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int lengthArray = Convert.ToInt32(Console.ReadLine());
// int [] res = Array123(lengthArray);
// ShowArray(res);
// int value = IntervalNumber(res);
// System.Console.WriteLine($"Количество чисел в интервале [10,99]: {value}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] Array123(int num)
// {
//     int [] array = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int SummOdd(int[] array){
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 > 0 || i == 1)
//             summ +=array[i];
            
//     }
//     return summ;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int lengthArray = Convert.ToInt32(Console.ReadLine());
// int [] res = Array123(lengthArray);
// ShowArray(res);
// int value = SummOdd(res);
// System.Console.WriteLine($"Сумма элементов нечетных позиций: {value}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

// int[] Array123(int num)
// {
//     int [] array = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int MaxNum(int[] array){
//     int max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//             max = array[i];
//     }
//     return max;
// }

// int MinNum(int[] array){
//     int min = 100;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//             min = array[i];
//     }
//     return min;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int lengthArray = Convert.ToInt32(Console.ReadLine());
// int [] res = Array123(lengthArray);
// ShowArray(res);
// int value = MaxNum(res);
// System.Console.WriteLine($"Mаксимальное число: {value}");
// int value1 = MinNum(res);
// System.Console.WriteLine($"Mинимальное число: {value1}");
// System.Console.WriteLine($"Разница max - min: {value - value1}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] Array123(int num)
// {
//     int [] array = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int [] MultNum(int[] array){
//     int [] mult = new int [array.Length];
//      for (int i = 0; i < array.Length; i++)
//     { 
            
//         mult[i] = array[i] * 2;

//     }
//     return mult;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int lengthArray = Convert.ToInt32(Console.ReadLine());
// int [] res = Array123(lengthArray);
// ShowArray(res);
// ShowArray(MultNum(res));


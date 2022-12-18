// Пример 1: Задайте массив из 12 элементов, заполнен случайными числами из  [-9, 9]
// Найдите сумму отрицательных и положительных элементов массива.
// Например в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29.
// сумма отрицательных равна -20.

// int [] CreateArray(int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
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

// int FindPosSumm(int [] array){

//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>0)
//         summ += array[i];
//     }
//     return summ;
// }

// int FindNegSumm(int [] array){

//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]<0)
//         summ += array[i];
//     }
//     return summ;
// }

// int size = 12;
// int min = -9;
// int max = 9;
// int [] array = CreateArray(size,min,max);
// ShowArray(array);
// Console.WriteLine($"Summ of positiv numbers is {FindPosSumm(array)}"); 
// Console.WriteLine($"Summ of negativ numbers is {FindNegSumm(array)}"); 



// Пример 2: Напишите программу замены элементов массива: положительные элементы
// замените на соответствующие отрицательные и наоборот. 

// int [] CreateArray(int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
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

// int [] Reverse(int [] array)
// {
//     int [] rev = new int [array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         rev[i] = array[i] * -1;
//     }
        
//     return rev;
// } 

// System.Console.WriteLine("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// //ShowArray(CreateArray(size,min,max));
// int [] arr = CreateArray(size,min,max);
// //System.Console.WriteLine($"Ваш массив {}  ");
// ShowArray(arr);
// ShowArray(Reverse(arr));



// Пример 3: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число 

// int [] CreateArray(int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
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



// bool FindNumber(int [] array, int numb){
//     bool flag = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == numb)
//         {
//             flag = true;
//         }
//     }
//     return flag;
// }


// int size = 8;
// int min = -9;
// int max = 9;
// int numb = 4;
// int [] array = CreateArray(size,min,max);
// ShowArray(array);
// bool flag = FindNumber(array, numb);
// if (flag) {Console.WriteLine("Yes");}
// else {Console.WriteLine("No");}


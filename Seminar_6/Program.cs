// Example 1: Напишите программу, которая перевернет одномерный массив 
// (последний элемент будет на первом месте, а первый на последнем и т.д.)
//[1, 2, 3, 4, 5] >> [5, 4, 3, 2, 1]

// int [] CreateArray(int size, int min, int max){
//     double [] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = (new Random().NextDouble())*100;
//     }
//     return array;
// }

// int [] CreateArray(int size, int min, int max){
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int [] array){
    
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i] }");
//     }
//     Console.WriteLine();
// }

// int [] ReversArray(int [] array){
//     int l = array.Length;
// for(int i = 0; i < l/2; i++){
//     int temp = array[i];
//     array[i] = array[l - 1 - i];
//     array[l - 1 -i] = temp;
//     }   
//     return array;
// }

// Console.WriteLine("Enter array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter array min element");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter array max element");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// int [] revarray = ReversArray(array);
// ShowArray(revarray);


// Example 2: Напишите программу которая преобразовывает 
// десятичное число в двоичное.
// 45 >> 101101 

// int [] CreateArray(int size, int min, int max){
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }
// void ShowArray(int [] array){
    
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i] }");
//     }
//     Console.WriteLine();
// }

// string BinarySystem (int num)
// {
//     string result = string.Empty;
//     while (num != 0)
//     {
//         result = num%2 + result;
//         Console.WriteLine(result);
//         num = num / 2;
//     }
//     return result;
// }

// Console.WriteLine("Ввведите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Число в двоичной системе {BinarySystem(num)}");

// int [] Array(int num){
//     int count = 0;
//     int temp = num;
//     while(temp != 0){
//         temp /=2;
//         count++;
//     }
//     int [] array = new int [count];
//     for (int i = 0; i < count; i++)
//     {
//         array[count - 1 -i] = num%2;
//         num/=2;
//     }
//     return array;
// }

//Example 3: Напишите программу которая на вход принимает числа и проверяет,
//может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольниа 
//меньше суммы двух других сторон.

// bool Triangle(int a, int b, int c){
//     bool flag = false;
//     if(a+b>c && a+c>b && b+c>a)
//         flag = true;
//     return flag;
// }

// Console.WriteLine("Enter a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter c");
// int c = Convert.ToInt32(Console.ReadLine());

// bool flag = Triangle(a,b,c);
// System.Console.WriteLine("Triangle is " + flag);


//Example 4: Не используя рекурсию выведите первые N чисел Фибоначчи.
//первые два числа Фибоначчи 0 и 1.
//Если N = 5 >> 0 1 1 2 3 

// void ShowArray(int [] array){
    
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($" {array[i]}");
//     }
//     Console.WriteLine();
// }


// void Fibonacci(int n, int num1, int num2){
//     int [] array = new int [n];
//     array[0] = num1;
//     array[1] = num2;
//     for (int i = 2; i < n; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     ShowArray(array);
// }

// Console.WriteLine("Inpute size: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpute number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpute number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Fibonacci(n, num1, num2);

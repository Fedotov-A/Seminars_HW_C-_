// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int MathPow(int num1, int num2)
// {
//     int pow = num1;
//     for (int i = 1; i < num2; i++)
//     {
        
//         pow = pow * num1;
//     }
//     return pow;
// }

// System.Console.WriteLine("Enter number 1:  ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter number 2:  ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int res = MathPow(num1, num2);
// Console.Write($"Your result is {num1} to {num2} degrees equal to {res}");


// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

// 1 вариант:

// int Summ(int num){
//     int count = 0;
//     int result = num;
//     while (count < num)
//     {
//         if(num == 0 && num <= 9){
//             return result = num;
//         }
//         else if(num >= 10 && num < 100)
//         { 
//         result = (num / 10) + (num % 10);
//         return result;        
//         }
//         else if(num >= 100 || num < 1000)
//         {
//             result = ((num / 10) % 10) + (num % 10) + (num /100);       
//             return result;
//         }
//             count +=num;
            
//     }
//     return result;
    
// }

// System.Console.WriteLine("Enter number:  ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = Summ(num);
// Console.Write($"Your result is {res} from the number {num}");  


// 2 вариант: 

//void Summ(int num){

//             int ed = (num % 10);
//             int dec = (num / 10);
//             int hund = (num / 100);
//             int thous = (num % 1000);

//     if(num >= 1 && num <= 10)
//     {
//         Console.WriteLine($"Сумма чисел - {num}");
//     }
//     else if(num >= 10 && num <= 100)
//         {
            
//             int num1 = (num / 10) + (num % 10); 
//             Console.WriteLine($"Сумма чисел - {num1}");
//         }   
//     else if(num >= 100 && num <= 1000)
//         {
//             int num1 = (num % 10) + (num / 100) + ((num % 100)/10); 
//             Console.WriteLine($"Сумма чисел - {num1}");
//         }
//     else
//         {
//          Console.WriteLine($"Ваше число не корректно");
//         }

// }
// Console.WriteLine($"Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Ваше число {num}");
// Summ(num);


// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва 
// элементов и выводит их на экран.


// int[] Array(int num)
// {
//     int [] arr = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         arr[i] = new Random().Next(1, 100);
//     }
//     return arr;
// }

// void ShowArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
// }

// System.Console.WriteLine("write number:");
// int lengthArray = Convert.ToInt32(Console.ReadLine());
// ShowArray(Array(lengthArray));
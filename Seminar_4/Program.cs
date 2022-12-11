// Задача 1: Напишите программу, которая принимает на вход число (А) 
// и выдает сумму чисел от 1 до А.

// int SummNumbers(int num)
// {
//     int summ = 0;
//     for (int i = 1; i <= num; i++)   
//         summ += i;
//     return summ;
// }

// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumbers(num);
// Console.WriteLine($"Summ of numbers from 1 to {num} is {summ}");


// while 

// int SummNumbers(int num)
// {
//     int summ = 0;
//     int i = 1; 
    
//     while(i <= num) {  
//         summ += i;
//         i++;
//     }
//     return summ;
// }

// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumbers(num);
// Console.WriteLine($"Summ of numbers from 1 to {num} is {summ}");


// Задача 2: Напишите программу которая принимает на вход число
// и выдает количество цифр в числе.

// int Counter(int num){

//     if (num == 0)
//     {
//         return 1;
//     }
//         else
//         {
//             int count = 0;
//             while(num > 0)
//             {
//                 num = num/10;
//                 count++;
//             }
//             return count;
//         }
// }

// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = Counter(num);
// Console.WriteLine($"Much of numbers is {res}");

// Задача 3: Напишите программу которая принимает на вход число N 
// и выдает произведение чисел от 1 до N

// int Umn(int num)
// {
//     if (num < 0)
//     {
//         num = num * (-1);
//     }
//     int umn = 1;
//     for(int i = 2; i <= num; i++)
//     {
//         umn = umn * i;
//     }
//     return umn;
// }
// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = Umn(num);
// Console.WriteLine($"Произведение чисел от {num} будет равна {res}");


// Задача 4: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

// int[] Array()
// {
//     int [] arr = new int[8];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
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

// ShowArray(Array());



// int[] Array(int numb)
// {
//     int [] arr = new int[numb];
//     for (int i = 0; i < numb; i++)
//     {
//         arr[i] = new Random().Next(5, 16);
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

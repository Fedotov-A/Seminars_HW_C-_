// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// void Pollindrome(int num){
//     if(num >= 10000 && num <= 99999)
//     {
//         int one = num / 10000;
//         int two = (num / 1000) % 10;
//         int four = (num / 10) % 10;;
//         int five = num % 10;;

//         if(one == five && two == four)
//         {
//             Console.WriteLine($"Ваше число - {num} палиндромное.");
//         }   
//         else if(one != five || two != four)
//         {
//             Console.WriteLine( $"Ваше число - {num} не палиндромное.");
//         }
//     }
//     else
//     {
//          Console.WriteLine($"Ваше число не корректно");
//     }

// }
// Console.WriteLine($"Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Pollindrome(num);


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Distance (int x, int x1, int y, int y1, int z, int z1) {
//     double d = Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2)+Math.Pow((z1-z),2));
//     Console.WriteLine($"Расстояние: {Math.Round(d,2)}");
// }

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату У: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату У1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Distance(x, x1, y, y1, z, z1);

// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.


// void CubeTab(int num){

//     for(int num1 = 1; num1<=num; num1++){
//         Console.Write(num1*num1*num1 + " ");
//     }
// }

// Console.Write("Enter number: ");
// int usnum = Convert.ToInt32(Console.ReadLine());

// CubeTab(usnum);
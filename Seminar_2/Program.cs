// Пример1: void Test(int a, int b) // невозвратная функция, не вернет значение метода
// {
//     if(a > b){
//         Console.WriteLine($"{a} больше {b}");
//     }else
//     {
//         Console.WriteLine($"{b} больше {a}");
//     }
// }
//  int num1 = 6;
//  int num2 = 5;
// Test(num1, num2);

// Пример 2: int Test (int a, int b) // возвратный метод
// {
//     if(a > b)
//         return a;
//     else
//         return b;
// }
 
//  int num1 = 5;
//  int num2 = 6;

//  int result = Test(num1, num2);
//  Console.WriteLine($"Результат - {result}");

// Пример 3: Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// int Line(){
//     int num = new Random().Next(10, 100);
//     Console.WriteLine($"Ваше число - {num}");
//     int dec = num / 10;
//     int ed = num % 10;
//     if(ed > dec)
//         return ed;
//     else if (dec == ed)
//         return dec;
//     else
//         return dec;
// }

// int res = Line();
// Console.WriteLine($"Большое число - {res}");

// Пример 4: Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// int Test()
// {
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine(num);
//     int hund = num / 100;
//     int ten = num / 10 % 10;
//     int one = num % 10;
//     return ((hund*10) + one);
// }

// int res = Test();
// Console.WriteLine(res);

// Пример 5: Напишите программу, которая будет принримать на вход два числа 
// и выводить, является ли второе число кратно первому. 
// Если число 2 не кратно числу 1,  то программа выводит остаток от деления.

// void Test(int num1, int num2)
// {
//     if(num2 % num1 == 0)
//     {
//         Console.WriteLine($"Число {num2} кратно числу {num1}");
//     }
//     else
//     {
//         int res = num2 % num1;
//         Console.WriteLine($"Число {num2} не кратно числу {num1}. Остаток от деления {res}");
//     }
// }

// Console.WriteLine($"Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Test(num1, num2);

// Напишите программу которая на вход принимает 2 числа и проверяет,
// являтся ли одно число квадратом другого.


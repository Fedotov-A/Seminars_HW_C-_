// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// void MidNum(int num)
// {
//     if(num < 100 || num >= 1000)
//     {
//         Console.Write("Error");
//     }
//     else
//     {
//         Console.WriteLine($"Ваше число - {num}");
//         int midnum = num / 10 % 10;
//         Console.WriteLine($"Второе число - {midnum}");
//     }
    
// }

// Console.WriteLine($"Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// MidNum(num);



// Задача 2: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// void LastNum(int num)
// {
//     if(num < 100)
//     {
//         Console.WriteLine($"Ваше число - {num}- Третьей цифры нет");
//     }
//     else if(num >=1000 && num <10000){
//         int num3 = (((num - (num % 10))/10)%10);
//         Console.WriteLine($"Ваше число - {num}");
//         int lastnum = num3 % 10;
//         Console.WriteLine($"Третья цифра - {lastnum}");
//     }
//     else if(num >=10000 && num <100000){
//         int num3 = (((num - (num % 100))/100)%10);
//         Console.WriteLine($"Ваше число - {num}");
//         int lastnum = num3 % 10;
//         Console.WriteLine($"Третья цифра - {lastnum}");
//     }
//     else
//     {
//         Console.WriteLine($"Ваше число - {num}");
//         int lastnum = num % 10;
//         Console.WriteLine($"Третья цифра - {lastnum}");
//     }
// }

// Правильно ли я понимаю в этой задаче будет зависеть 
// до какого максимального числа мы долны проверять значение аргумента, 
// либо ограничить сам аргумент для ввода или есть альтернативное решение?

// Console.WriteLine($"Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// LastNum(num);



// Задача 3: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// void Weekend(int daynum)
// {
//     if(daynum == 1)
//     {
//         Console.WriteLine($"it's a day off - {daynum}- no ");
//     }
//     if(daynum == 2)
//     {
//         Console.WriteLine($"it's a day off - {daynum}- no ");
//     }
//     if(daynum == 3)
//     {
//         Console.WriteLine($"it's a day off - {daynum}- no ");
//     }
//     if(daynum == 4)
//     {
//         Console.WriteLine($"it's a day off - {daynum}- no ");
//     }
//     if(daynum == 5)
//     {
//         Console.WriteLine($"it's a day off - {daynum}- no ");
//     }
//     if(daynum == 6)
//     {
//         Console.WriteLine($"it's a day off - {daynum}- yes ");
//     }
//     if(daynum == 7)
//     {
//         Console.WriteLine($"it's a day off - {daynum}- yes ");
//     }
//     else{
//         Console.WriteLine($"Ваше число - {daynum} некорректно");
//     }    
// }



// Console.WriteLine($"Введите порядковый номер дня недели: ");
// int daynum = Convert.ToInt32(Console.ReadLine());

// Weekend(daynum);



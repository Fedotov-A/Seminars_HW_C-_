// Задача 1: 
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

/*Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Это число max = {number1}, это число min = {number2}");
}
else
{
    Console.WriteLine($"Это число max = {number2}, это число min = {number1}");
}*/

// Задача 2: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

/*Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;
 if(num1 > max) max = num1;
 if(num2 > max) max = num2;
 if(num3 > max) max = num3;

 Console.WriteLine($"Это максимальное число: {max}");*/

 // Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
 // является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Введите число: ");
string str = Console.ReadLine();
double divider = 2;
double num1;

if(Double.TryParse(str, out num1) == true)
{
    double num = Convert.ToDouble(str);
    if(num > 0 & num % 2 == 0){
        Console.WriteLine($"Это число {num1} являтся четным!");
    } else if(num1 % divider > 0)
{
    Console.WriteLine($"Это число {num1} не являтся четным!");
}
else if(num < 0){
    Console.WriteLine("Вы ввели отрицательное число");
}
}
else
{
    Console.WriteLine("Вы ввели не корректное значение");
}*/

// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

/*Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
int num = 0;

while (count <= N)
{ 
    Console.WriteLine(num = num + 2);
    count = count + 2;
}*/

// Написать программу которая из имеющегося массива строк формирует массив из 
// строк, длина которых мень ше либо равна 3 символа. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
// решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string [] ArrayString(int num){
    string [] array = new string [num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i+1} строку: ");
        array[i] = Console.ReadLine();
        while (array[i] == "")
        {
            Console.WriteLine("Введите корректное значение: ");
            Console.WriteLine($"Введите {i+1} строку: ");
            array[i] = Console.ReadLine();
        }

    }
    return array;
}

void ShowArray(string [] array){
    
    for (int i = 0; i < array.Length; i++){
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}

void MaxNum3(string[] array){

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            Console.Write($"{array[i]}   ");     
    }
}

System.Console.WriteLine("Введите желаемое количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string [] zero = ArrayString(num);
ShowArray(zero);
Console.WriteLine();
Console.WriteLine($"Строки, длина которых меньше либо равна 3 символам!!! ");
MaxNum3(zero);

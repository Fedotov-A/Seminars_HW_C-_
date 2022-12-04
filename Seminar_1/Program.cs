//Задача 1
Console.Write("Введите первое число: ");
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
}

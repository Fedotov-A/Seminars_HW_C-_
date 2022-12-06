// Пример 1: напишите программу, которая принимает на вход координаты точки (X и Y)
//причем X не равно 0, Y не равно 0, и выдает номер четверти плоскости, 
// в которой находится эта точка.

// void SearchSquad(int x, int y){
//     if(x==0 || y==0)
//     Console.WriteLine("Error");
//     else if(x>0 && y>0)
//     Console.WriteLine("Точка находится в 1 четверти");
//     else if(x>0 && y<0)
//     Console.WriteLine("Точка находится в 2 четверти");
//     else if(x<0 && y>0)
//     Console.WriteLine("Точка находится в 3 четверти");
//     else 
//     Console.WriteLine("Точка находится в 4 четверти");
// }

// Console.Write("Enter coordinate X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate Y: ");
// int y = Convert.ToInt32(Console.ReadLine());       

// SearchSquad(x,y);

// Пример 2: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

// void Search(int z)
// {
//     if (z == 1)
//     {
//         System.Console.WriteLine("X положительное, Y положительное");
//     }
//     else if (z == 2)
//     {
//         System.Console.WriteLine("X отрицательный, Y Положительный");
//     }
//     else if (z == 3)
//     {
//         System.Console.WriteLine("X отрицательный, Y отрицательный");
//     }
//     else if (z == 4)
//     {
//         System.Console.WriteLine("X положительный, Y отрицательный");
//     }
//     else
//     {
//         System.Console.WriteLine("Введите число обозначающую четверть");
//     }
// }

// System.Console.WriteLine("Введите номер четверти: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Search(z);


// Пример 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N

// void SquareTab (int x) {
// int a = 1;
// int count = 0;
//    while (count < x){
//     Console.WriteLine(a*a);
//     a++;
//     count++;
//    }
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SquareTab(n);

// Пример 4: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

// void Dist (int x, int x1, int y, int y1) {
//     double d = Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2));
//     Console.WriteLine($"Расстояние: {Math.Round(d,2)}");
// }

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату У: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату У1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Dist(x, x1, y, y1);



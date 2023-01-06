//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int [] Array123(int num){
    int [] array = new int [num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int [] array){
    
    for (int i = 0; i < array.Length; i++){
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}

int AboveZero(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if(array[i]>0){
            count = count +1;
        }
    }
    return count;
    
}

System.Console.WriteLine("Введите желаемое количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [] zero = Array123(num);
ShowArray(zero);
int res = AboveZero(zero);
Console.WriteLine($"Количество чисел больше нуля:  {res}");

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();
Console.WriteLine("Введите числа через пробел:");
string [] array = Console.ReadLine().Split(); 

int AboveZero (string[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int num = int.Parse(arr[i]);
        if (num > 0) res++;
    }
    return res;
}

Console.WriteLine($"{String.Join(", ", array)} -> {AboveZero(array)}");
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/

Console.Clear();
Console.WriteLine();
Console.Write($"Введи количество посчитываемых чисел: ");
int nums = Convert.ToInt32(Console.ReadLine());
int[] arroy = new int[nums];
Console.WriteLine();

void input(int nums)
{
    for (int i = 0; i < nums; i++)
    {
        Console.Write($"Будь любезен, введи {i + 1}-е число: ");
        arroy[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int matching(int[] arroy)
{
    int result = 0;
    for (int i = 0; i < arroy.Length; i++)
    {
        if (arroy[i] > 0) result += 1;
    }
    return result;
}

input(nums);
Console.WriteLine();
Console.WriteLine($"Ты ввёл {matching(arroy)} числа больше 0");
Console.WriteLine();
Console.WriteLine($"Благодарю! \tЖду дальнейших инструкций! ");
Console.WriteLine();
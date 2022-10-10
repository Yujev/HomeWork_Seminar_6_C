/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
Console.WriteLine("Задача 43: \"Напиши программу, которая найдёт точку пересечения двух прямых, заданных уравнениями\"");
Console.WriteLine("Значения задаёшь сам...");
Console.WriteLine();

Console.Write("Будь любезен, введи значение \"b1\": \n");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Будь любезен, введи значение \"k1\": \n");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Будь любезен, введи значение \"b2\": \n");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Будь любезен, введи значение \"k2\": \n");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double xCrossPoint = 0;
double yCrossPoint = 0;
if (b1 == b2 & k1 == k2) Console.WriteLine("Эти прямые совпадают");
else if (k1 == k2) Console.WriteLine("Ну, а эти прямые параллельны");
else
{
    xCrossPoint = (b2 - b1) / (k1 - k2);
    yCrossPoint = k1 * xCrossPoint + b1;
    Console.WriteLine("Твоя точка пересечения прямых: " + " ( " + xCrossPoint + "; " + yCrossPoint + " )");
}

Console.WriteLine();
Console.WriteLine($"Благодарю! \tЖду дальнейших инструкций... ");
Console.WriteLine();

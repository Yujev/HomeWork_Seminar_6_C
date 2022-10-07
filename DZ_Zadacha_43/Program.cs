/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 43: \"Напиши программу, которая найдёт точку пересечения двух прямых, заданных уравнениями\"");
Console.WriteLine();

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.WriteLine();
        Console.Write($"Введи коэффициенты для {i + 1}-го уравнения (y = k * x + b):\n");
        Console.WriteLine();
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Будь любезен, введи коэффициент K: ");
            else Console.Write($"Будь любезен, введи коэффициент B: ");
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] coeff)
{
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return crossPoint;
}

void OutputResponse(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.Write($"\nЭти прямые совпадают");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.Write($"\nА эти прямые параллельны");
    }
    else
    {
        Decision(coeff);
        Console.Write($"\nТвоя точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoefficients();
OutputResponse(coeff);
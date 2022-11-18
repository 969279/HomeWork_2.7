/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
double [] result = new double[columns];

FillArray2D(array);
Write2DArray(array);
Console.WriteLine();
AverageArray(array, result);

void AverageArray(int [,] numbers, double[] result)
{
     for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            result[j] += Convert.ToDouble(numbers[i,j]);
        }
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int k = 0; k < result.Length; k++)
        {
            result[k] = Math.Round(result[k] / rows, 2);
            Console.Write(result[k] + "; ");
        }
        Console.WriteLine($"{result[result.Length - 1]}. ");
}
    
void FillArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
     for (int j = 0; j < numbers.GetLength(1); j++)
        {
        numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void Write2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

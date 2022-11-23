/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. 
Во вводе первая цифра - номер строки, вторая - столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int rowsNumber = ReadInt("Введите номер строки: ");
int columnsNumber = ReadInt("Введите номер столбца: ");
int rows = 4, columns = 4;
int[,] numbers = new int[rows, columns];

Fill2DArray(numbers);
Write2DArray(numbers);
ChoiceElement(numbers);

void ChoiceElement(int[,] numbers)
{
    if(rowsNumber > 0 && rowsNumber <= numbers.GetLength(0) && columnsNumber > 0 && columnsNumber <= numbers.GetLength(1))
    {
        Console.WriteLine($"Элемент [{rowsNumber},{columnsNumber}] = {numbers[rowsNumber - 1, columnsNumber - 1]}");
    }
    else {Console.WriteLine($"Элементa [{rowsNumber},{columnsNumber}] в массиве не существует");}
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
     for (int j = 0; j < numbers.GetLength(1); j++)
        {
        numbers[i, j] = new Random().Next(-9, 10);
        }
    }
}

void Write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
/*
int[,] numbers = new int[,] { {1, 3, 4}, {5, 7, 9}};

int position = Convert.ToInt32(Console.ReadLine());
int row = position / 10;
int column = position % 10;

if(numbers.GetLength(0) <= row || numbers.GetLength(1) <= column)
{
    Console.WriteLine("Такой позиции нет");
    return;
}

Console.WriteLine(numbers[row, column]);
*/
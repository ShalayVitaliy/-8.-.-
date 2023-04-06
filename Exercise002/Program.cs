// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 16);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}

void FindSumOfRow(int[,] matrix, int[] array)
{
    int sum = 0;
    for(int row = 0; row < matrix.GetLength(0); row++)
    {
        for(int column = 0; column < matrix.GetLength(1); column++)
        {
           sum += matrix[row, column];
           
        }
        array[row] = sum;
        sum = 0;
    }

}

void PrintSumArray(int[] array)
{
    
    Console.Write($"[{string.Join(", ", array)}]");
    
}

int FindTheLowestSum(int[] array)
{
    int minIndex = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            minIndex = i;
    }
    return minIndex;
}

Console.Clear();
Console.Write("Enter a size of matrix: ");
int[] Size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Matrix = new int[Size[0], Size[1]];
int[] Sum = new int[Matrix.GetLength(1)];
InputMatrix(Matrix);
FindSumOfRow(Matrix, Sum);
Console.WriteLine();
PrintSumArray(Sum);
Console.WriteLine();
Console.Write($"The lowest sum is locating in the [{FindTheLowestSum(Sum)}] row of matrix.");
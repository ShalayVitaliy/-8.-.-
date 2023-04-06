// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int InputNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

void MultiplicatedMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i,j] = sum;
        }

    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int row1 = InputNumber("Enter the size of rows of 1-st matrix: ");
int column1Row2 = InputNumber("Enter the size of columns of the 1-st matrix (the rows of the 2-nd): ");
int column2 = InputNumber("Enter the size of columns of 2-nd matrix: ");

int[,] firstMatrix = new int[row1, column1Row2];
int[,] secondMatrix = new int[column1Row2, column2];
int[,] multiplicatedMatrix = new int[row1, column2];

Console.WriteLine("The first matrix is: ");
InputMatrix(firstMatrix);
Console.WriteLine("The second matrix is: ");
InputMatrix(secondMatrix);
Console.WriteLine("The multiplicated matrix is: ");
MultiplicatedMatrix(firstMatrix, secondMatrix, multiplicatedMatrix);
PrintMatrix(multiplicatedMatrix);
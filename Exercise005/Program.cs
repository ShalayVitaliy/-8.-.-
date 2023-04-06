// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void InputMatrix(int[,] matrix, int n)
{
    for (int i = n + 1; i < matrix.GetLength(1) - n; i++)
        matrix[n, i] = matrix[n, i - 1] + 1;
    for (int i = n + 1; i < matrix.GetLength(0) - n; i++)
        matrix[i, matrix.GetLength(1) - n - 1] = matrix[i - 1, matrix.GetLength(1) - n - 1] + 1;
    for (int i = matrix.GetLength(1) - n - 2; i >= n; i--)
        matrix[matrix.GetLength(0) - n - 1, i] = matrix[matrix.GetLength(0) - n - 1, i + 1] + 1;
    for (int i = matrix.GetLength(0) - n - 2; i > n; i--)
        matrix[i, n] = matrix[i + 1, n] + 1;
    if (matrix[n + 1, n + 1] == 0)
    {
        matrix[n + 1, n + 1] = matrix[n + 1, n] + 1;
        InputMatrix(matrix, n + 1);
    }
}

int[,] CreateMatrix()
{
    Console.Write("Enter a size of matrix: ");
    int[] Size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[Size[0], Size[1]];
    matrix[0,0] = 1;
    InputMatrix(matrix,0);
    return matrix;
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
int[,] Matrix = CreateMatrix();
PrintMatrix(Matrix);
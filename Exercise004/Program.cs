// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void InputMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(0, 16);
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) \t");
            }
        }
        Console.WriteLine();
    }

}

Console.Clear();
Console.Write("Enter a size of matrix: ");
int[] Size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] Matrix = new int[Size[0], Size[1], Size[2]];

InputMatrix(Matrix);
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите размеры матрицы");
int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
double[,] matrix = new double[size[0],size[1]];

void CreateMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      matrix[i,j]= Math.Round(new Random().NextDouble() + new Random().Next(-10,10),2);
      System.Console.Write($"{matrix[i,j]}\t");
    }
  System.Console.WriteLine();
  }
}

CreateMatrix(matrix);
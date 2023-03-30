// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int n, int m)
{
  int[,] matrix = new int[n,m];
  for (int i = 0; i < matrix.GetLength(1); i++)
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      matrix[j,i] = new Random().Next(-10,11);
    }
return matrix;
}

void WriteMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(1); i++)
    {
      for (int j = 0; j < matrix.GetLength(0); j++)
      {
        System.Console.Write($"{matrix[j,i]}\t");
      }
      System.Console.WriteLine();
    }
}

double AverageColumn(int[,] matrix, int numberOfColumn)
{
  int sumOfValues = 0;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    sumOfValues += matrix[numberOfColumn,i];
  }
  double average = Math.Round(Convert.ToDouble(sumOfValues)/Convert.ToDouble(matrix.GetLength(1)),2);
  return average;
}

System.Console.WriteLine("Введите размеры матрицы (2 числа)");
int[] sizes = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] twoDimentionArray = CreateMatrix(sizes[0],sizes[1]);
WriteMatrix(twoDimentionArray);
for (int i = 0; i < twoDimentionArray.GetLength(0);i++)
System.Console.WriteLine($"Среднее арифметическое {i+1}-ого столбца матрицы составляет {AverageColumn(twoDimentionArray, i)}");







// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.

int[,] InputMatrix(int x, int y)
{
  int[,] matrix = new int[x,y];
  for (int i = 0; i < y; i++)
    for  (int j = 0; j < x; j++)
    {
      matrix[j,i] = new Random().Next(-100,101);
    }
return matrix;
}

void WriteMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++) System.Console.Write($"{matrix[j,i]}\t");
    System.Console.WriteLine();
  }
}

int[,] TranspositionMatrix(int[,] matrix)
{
int[,] transposedMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(0); i++)
  for (int j = 0; j < matrix.GetLength(1); j++) transposedMatrix[i,j] = matrix[i,matrix.GetLength(1) - j -1];
return transposedMatrix;
}


Console.WriteLine("Введите длину и высоту двумерного массива");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = InputMatrix(size[0], size[1]);
WriteMatrix(matrix);
System.Console.WriteLine();
WriteMatrix(TranspositionMatrix(matrix));
// Заполнить массив диагоналями как показано на рисунке

int[,] InputMatrix (int horizontalSize, int verticalSize)
{ 
  int currentValue = 0;
  int[,] matrix = new int[horizontalSize,verticalSize];
  for (int k = 0; k < horizontalSize + verticalSize - 1; k++)
    for (int i = k; i >= 0 && k-i < verticalSize; i--)
    {
      if (i < horizontalSize)
      {
        matrix[i,k-i] = currentValue;
        currentValue++;
      }
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


System.Console.WriteLine("Введите размеры матрицы (ширину и высоту)");
int[] size = Console.ReadLine()!.Split().Select(a => int.Parse(a)).ToArray();
WriteMatrix(InputMatrix(size[0],size[1]));

// 0 0    k = 0  x = k    y = k - x 
//         x = 0  --- k++ конец цикла
// 1 0    k = 1  x = k    y = k - x 
// 0 1    k = 1  x = k-1  y = k - x
//         x = 0  --- k++ конец цикла
// 2 0    k = 2  x = k    y = k - x
// 1 1    k = 2  x = k-1  y = k - x
// 2 0    k = 2  x = k-2  y = k - x
//         x = 0  --- k++ конец цикла
// 3 0
// 2 1
// 1 2
// 0 3


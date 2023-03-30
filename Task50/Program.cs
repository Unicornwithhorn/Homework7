// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такой позиции нет.

int[,] InputMatrix()
{
  System.Console.WriteLine("Введите размеры матрицы");
  int[] size = Console.ReadLine()!.Split().Select(k => int.Parse(k)).ToArray();
  int[,] matrix = new int[size[0],size[1]];
  for (int i = 0; i < size[0]; i++)
  {
    for (int j = 0; j < size[1]; j++) matrix[i,j] = new Random().Next(0,10);
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        System.Console.Write($"{matrix[i,j]}\t");
      }
      System.Console.WriteLine();
    }
}


int[,] mymatrix = InputMatrix();
PrintMatrix(mymatrix);
System.Console.WriteLine("Введите координаты запрашиваемого элемента матрицы");
System.Console.WriteLine("Сначала по горизонтали (нумерация с 1 элемента слева направо)");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Теперь по вертикали (нумерация с 1 элемента сверху вниз)");
int m = int.Parse(Console.ReadLine()!);
if (n <= mymatrix.GetLength(0) && m <= mymatrix.GetLength(1)) System.Console.WriteLine($"Значение запрашиваемого элемента - {mymatrix[n-1,m-1]}");
else System.Console.WriteLine("такой позиции нет");


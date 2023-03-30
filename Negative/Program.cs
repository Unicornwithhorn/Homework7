// Первая строка входного файла INPUT.TXT содержит целые числа n и m (1 ≤ n, m ≤ 100) – высоту и ширину исходного изображения
// (в пикселях). Последующие n строк содержат описание исходного изображения. Каждая строка состоит из m символов «B» и «W».
// Символ «B» соответствует черному пикселю, а символ «W» – белому. Далее следует пустая строка, а после нее –
// описание выведенного Мишиной программой изображения в том же формате, что и исходное изображение.

// В выходной файл OUTPUT.TXT необходимо вывести число пикселей негатива, которые неправильно сформированы Мишиной программой.

string[,] CreateImage(int x, int y)
{
  string[,] image = new string[x,y];
  for (int i = 0; i < y; i++)
    for (int j = 0; j < x; j++)
    {
      if (new Random().Next(2) == 0) image[j,i] = "B";
      else image[j,i] = "W";
    }
  return image;
}

void WriteMatrix(string[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(1); i++)
    {
    for (int j = 0; j < matrix.GetLength(0); j++) System.Console.Write($"{matrix[j,i]}\t");
    System.Console.WriteLine();
    }
}


Console.WriteLine("Введите разрешение изображения (ширина х высота)");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
string[,] photo = CreateImage(size[0],size[1]);
System.Console.WriteLine("Фото");
WriteMatrix(photo);
System.Console.WriteLine();
string[,] negative = CreateImage(size[0],size[1]);
System.Console.WriteLine("Негатив");
WriteMatrix(negative);

int countOfErrors = 0;
for (int i = 0; i < size[1]; i++)
  for (int j = 0; j < size[0]; j++)
    if (photo[j,i]==negative[j,i]) countOfErrors+=1;
System.Console.WriteLine("Число ошибок - {0}", countOfErrors);
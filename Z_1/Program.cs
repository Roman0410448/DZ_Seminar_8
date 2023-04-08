Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = GetMatrix(rows, columns, 0, 10); // Вызов метода
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // Матрица: m строк и n столбцов
    for (int i = 0; i < m; i++) // m = matrix.GetLenth(0) - строчки
    {
        for (int j = 0; j < n; j++) // n = matrix.GetLenth(1) - столбцы
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
PrintMatrix(array2D);
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write(array[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
        }
        Console.WriteLine(); // Переход на новую строчку
    }
}

SortArray(array2D);
Console.WriteLine("Отсортированный массив: ");
PrintMatrix(array2D);

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < (arr.GetLength(1) - 1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, j])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
        }
    }
}
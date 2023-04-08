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
        Console.WriteLine();// Переход на новую строчку
    }
}

int minRow = FindMinRow(array2D); // находим строку с наименьшей суммой элементов
Console.WriteLine("Строка с наименьшей суммой элементов: " + minRow); // выводим найденную строку

int FindMinRow(int[,] arr)
{
    int minRow = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i+1;
        }
    }

    return minRow;
}


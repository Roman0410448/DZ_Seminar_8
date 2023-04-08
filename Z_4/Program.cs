// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите глубину: ");
int deeps = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = GetMatrix(rows, columns, deeps, 0, 10); // Вызов метода
int[,,] GetMatrix(int m, int n, int k, int min, int max)
{
    int[,,] matrix = new int[m, n, k]; // Матрица: m строк и n столбцов
    for (int i = 0; i < m; i++) // m = matrix.GetLenth(0) - строчки
    {
        for (int j = 0; j < n; j++) // n = matrix.GetLenth(1) - столбцы

        {
            for (int e = 0; e < k; e++)
            {
                matrix[i, j, e] = new Random().Next(min, max + 1);
            }
        }
    }
    return matrix;
}
PrintMatrix(array3D);
void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            for (int e = 0; e < array.GetLength(2); e++)
            {
                Console.Write($"{array[i, j, e]}({i},{j},{e}); ");
            }
        }
        Console.WriteLine(); // Переход на новую строчку
    }
    Console.WriteLine();
}
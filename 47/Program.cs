// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print2dMassive(double[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {

           Console.Write($"{massive[i,j]}\t", 5);
        }
    Console.WriteLine();
    }
}   

double [,] GetMassive(int row, int col, int start, int finish)
{
    double [,] matrix = new double [row, col];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i,j] = new Random().Next(start, finish+1)* 0.1;
        }
    } 
    return matrix;
}
int GetSize(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetSize("сколько строк?");
int n = GetSize("сколько столбцов?");
double [,] massive = GetMassive(m,n, -100, 100);

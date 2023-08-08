// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Average(int[,] massive)
{
    // double num = 0;
    for(int i = 0; i < massive.GetLength(1); i++)
    {
        double sum = 0;
                for(int j = 0; j < massive.GetLength(0); j++)
        {
            sum += massive [j,i];
           
        }
    Console.Write($"{Math.Round(sum / massive.GetLength(0),1)}\t ");
    }

}


void Print2dMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {

           Console.Write($"{massive[i,j]}\t", 4);
        }
    Console.WriteLine();
    }
}   

int[,] GetMassive(int row, int col, int start, int finish)
{
    int [,] matrix = new int [row, col];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i,j] = new Random().Next(start, finish+1);
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
int [,] massive = GetMassive(m,n, 1, 9);
Print2dMassive(massive);
Average(massive);
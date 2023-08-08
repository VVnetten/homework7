// Тут 2 решения, сохранила оба. На проверку сдаю то, которое не закоментировано

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void GetPosition(int[,] massive, int row, int col)
{
    int num = 0;
       if (row < massive.GetLength(0) & col < massive.GetLength(1))
    {
        num = massive [row, col];
        Console.WriteLine(num);
    }
    else {Console.WriteLine("такого элемента нет");}
    
}

void Print2dMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {

           Console.Write($"{massive[i,j]}\t", 3);
        }
    Console.WriteLine();
    }
}    

int [,] GetMassive(int row, int col, int start, int finish)
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
int row = GetSize("позиция в строке?");
int col = GetSize("позиция в столбце?");
int [,] massive = GetMassive(m,n, 1, 10);


Print2dMassive(massive);
Console.WriteLine();
GetPosition(massive, row, col);


// string GetPosition(int[,] massive, int row, int col)
// {
//     int num = 0;
//     string result = String.Empty;
//     if (row < massive.GetLength(0) & col < massive.GetLength(1))
//     {
//         num = massive [row, col];
//         result = Convert.ToString(num);
//     }
//     else { result = "такого элемента нет";}
//     return result;
// }

// void Print2dMassive(int[,] massive)
// {
//     for(int i = 0; i < massive.GetLength(0); i++)
//     {
//         for(int j = 0; j < massive.GetLength(1); j++)
//         {

//            Console.Write($"{massive[i,j]}\t", 3);
//         }
//     Console.WriteLine();
//     }
// }    

// int [,] GetMassive(int row, int col, int start, int finish)
// {
//     int [,] matrix = new int [row, col];
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {

//             matrix[i,j] = new Random().Next(start, finish+1);
//         }
//     } 
//     return matrix;
// }
// int GetSize(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int m = GetSize("сколько строк?");
// int n = GetSize("сколько столбцов?");
// int row = GetSize("позиция в строке?");
// int col = GetSize("позиция в столбце?");
// int [,] massive = GetMassive(m,n, 1, 10);
// string position  = GetPosition(massive, row, col);

// Print2dMassive(massive);
// Console.WriteLine();
// Console.WriteLine(position);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
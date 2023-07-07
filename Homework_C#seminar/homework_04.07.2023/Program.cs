/*
Знакомство с языками программирования (семинары)
Урок 8. Двумерные массивы. Продолжение
Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row,col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            array[i,j] = rand.Next(min,max+1); 
        } 
    } 
    return array; 
} 
 
void PrintArray(int [,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 

int[,] CreateArray2(int[,] array2){//Переворот
for (int i = 0; i < array2.GetLength(0); i++)
{
    int[] row = new int[array2.GetLength(1)];
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        row[j] = array2[i, j];
    }
    Array.Sort(row);
    Array.Reverse(row);
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = row[j];
    }
}
return array2;
}

void PrintArray2(int [,] array2){ 
    int row = array2.GetLength(0); 
    int col = array2.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array2 [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 

Console.Clear();
int [,] array = CreateArray(5,5,0,10); 
PrintArray(array); 
Console.WriteLine(); 
int [,] array2 = CreateArray2(array); 
PrintArray2(array2);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка
*/
/*
int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row,col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            array[i,j] = rand.Next(min, max+1); 
        } 
    } 
    return array; 
} 
 
void PrintArray(int [,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    int[] sums = new int[row];
    for (int i = 0; i < row; i++) 
    { 
        int sum = 0;
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t");            
            sum += array[i, j]; 
        }
        Console.WriteLine();
        sums[i] = sum;       
    }
    int[] sumsArray = (int[])sums.Clone();
    int minSum = sumsArray.Min();
    int minIndex = Array.IndexOf(sumsArray, minSum); 
    Console.Write($"Line number with the smallest amount: {minIndex}");    
} 
 
Console.Clear();
int [,] array = CreateArray(3,3,0,10); 
PrintArray(array); 
Console.WriteLine();
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
void CreateArrays(out int[,] array, out int[,] array2, out int[,] array3, int row, int col, int row2, int col2, int min, int max)
{
    Random rand = new Random();
    array = new int[row, col];
    array2 = new int[row2, col2];
    array3 = new int[row, col2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }

    for (int i = 0; i < row2; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            array2[i, j] = rand.Next(min, max + 1);
        }
    }

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            int sum = 0;
            for (int k = 0; k < col; k++)
            {
                sum += array[i, k] * array2[k, j];
            }
            array3[i, j] = sum;
        }
    }
}

void PrintArrays(int[,] array, int[,] array2, int[,] array3)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    Console.WriteLine("Matrix 1:");
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }

    int row2 = array2.GetLength(0);
    int col2 = array2.GetLength(1);

    Console.WriteLine("Matrix 2:");
    for (int i = 0; i < row2; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            Console.Write($"{array2[i, j]}\t");
        }
        Console.WriteLine();
    }

    int row3 = array3.GetLength(0);
    int col3 = array3.GetLength(1);

    Console.WriteLine("The result of matrix multiplication:");
    for (int i = 0; i < row3; i++)
    {
        for (int j = 0; j < col3; j++)
        {
            Console.Write($"{array3[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int[,] array, array2, array3;
CreateArrays(out array, out array2, out array3, 2, 2, 2, 2, 0, 10);
PrintArrays(array, array2, array3); 
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
int[,,] CreateUniqueArray(int size1, int size2, int size3){
    int[,,] array = new int[size1, size2, size3];
    HashSet<int> usedNumbers = new HashSet<int>();

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                int number;
                do
                {
                    number = GetRandomTwoDigitNumber();
                } while (usedNumbers.Contains(number));

                array[i, j, k] = number;
                usedNumbers.Add(number);
            }
        }
    }

    return array;
}

int GetRandomTwoDigitNumber()
{
    Random rand = new Random();
    return rand.Next(10, 100);
}

void PrintArrayWithCoordinates(int[,,] array)
{
    int size1 = array.GetLength(0);
    int size2 = array.GetLength(1);
    int size3 = array.GetLength(2);

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                int number = array[i, j, k];
                Console.WriteLine($" {number}({i}, {j}, {k})");
            }
        }
    }
}
Console.Clear();
int[,,] array = CreateUniqueArray(2, 2, 2);
PrintArrayWithCoordinates(array);
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/*
void FillSpiralArray(int[,] array, int n)
{
    int value = 1;
    int rowStart = 0, rowEnd = n - 1;
    int colStart = 0, colEnd = n - 1;

    while (value <= n * n)
    {
        // Заполнение верхней горизонтальной строки
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = value++;
        }
        rowStart++;

        // Заполнение правого вертикального столбца
        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = value++;
        }
        colEnd--;

        // Заполнение нижней горизонтальной строки в обратном порядке
        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = value++;
            }
            rowEnd--;
        }

        // Заполнение левого вертикального столбца в обратном порядке
        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = value++;
            }
            colStart++;
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int[,] array = new int[4, 4];
FillSpiralArray(array, 4);
PrintArray(array);
*/
/* 
Знакомство с языками программирования (семинары)
Урок 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
З.Ы. Пусть выводимые на консоль элементы будут разных цветов.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.Clear();
//Создаём массив случайных вещественных чисел со вторым 
//знаком после зпт.
double [,] CreatArray(int row, int col){
    Random rand = new Random();
    double [,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
           array[i,j] = Math.Round(new Random().Next(0,10) + new Random().NextDouble(),2); 
        }
    } 
    return array;
}
//Выводим массив на консоль, добавляем цветность.
void PrintArray(double[,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    ConsoleColor[] colArray = new ConsoleColor[]{
 ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
 ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
 ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
 ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
 ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
 ConsoleColor.Yellow};
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}
double[,] array = CreatArray(15,15);
PrintArray(array);
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента или 
же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*

*/
/*
Console.Clear();

// Функция для чтения данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Функция для создания массива сo случайными значениями
int[,] CreateArray(int row, int col, int min, int max){
    Random rand = new Random();
    int[,] array = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

// Функция для поиска элемента в массиве
bool FindElement(int[,] array, int x, int y, out int foundElem)
{
    foundElem = 0;
    if (x >= 0 && x < array.GetLength(0) && y >= 0 && y < array.GetLength(1))
    {
        foundElem = array[x, y];
        return true;
    }
    return false;
}

int[,] array = CreateArray(5, 5, 1, 10);
int x = ReadData("Enter the row number: ");
int y = ReadData("Enter the column number: ");

if (FindElement(array, x, y, out int findNum))
{
    array[x, y] = findNum; 
    Console.WriteLine($"Element {findNum} found at ({x}, {y})");
}
else
{
    Console.WriteLine("Element not found. Please check the input.");
}

// Выводим массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
З.Ы. И по диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();

// Метод ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


//Метод для заполнения 2D массива целыми (int) числами
int[,] Gen2DArrayInt(int row, int column)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, 101);
            j++;
        }
        i++;
    }
    return arr;
}

//Метод вывода 2D массива в консоль
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            Console.Write(arr[i, j]+"\t");
            Console.ResetColor(); 
        }
        Console.WriteLine("");
    }
}

// Метод печати 1D массива в консоль
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
        Console.Write(arr[i] + ", ");
        Console.ResetColor();
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


// Метод подсчета среднего арифметического по столбцам
int[] MeanColum(int[,] arr)
{
    int[] means = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            means[i] = means[i] + arr[j, i];
        }
        means[i] = means[i] / arr.GetLength(0);
    }
    return means;
}

// Метод подсчета среднего арифметического по диагонали
int DiagAverage(int[,] arr)
{
    int res = 0;
    int count = 0;
    int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);

    for (int i = 0; i < min; i = i + 1)
    {
        res = res + arr[i, i];
        count = count + 1;
    }
    res = res / count;
    return res;
}


// 1. Получение данных от пользователя
int row = ReadData("Количество строк матрицы: ");
int column = ReadData("Количество столбцов матрицы: ");

// 2. Генерируем 2D массив
int[,] arr2D = Gen2DArrayInt(row, column);

// 3. Считаем среднее арифметическое по столбцам
int[] average = MeanColum(arr2D);

// 4. Печатаем 2D Массив
Print2DArr(arr2D);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам: ");
// 5. Печатаем 1D Массив
Print1DArr(average);

int diagAver = DiagAverage(arr2D);
Console.WriteLine("Среднее арифметическое по диагонали: ");
Console.WriteLine(diagAver);
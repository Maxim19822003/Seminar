﻿ // Задача №48
 // Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
 // Aₘₙ = m+n. Выведите полученный массив на экран.
/* 
Console.Clear();
 ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                         ConsoleColor.Yellow};

 //1) Получение данных от пользователя
 int n = InputNum("Количество строк матрицы");
 int m = InputNum("Количество строк матрицы");

 //2) Генерация двумерного массива
 int[,] matix = FillTwoDimArray(n,m);

/* //3) Печатаем двумерный массив
 PrintTwoDimArray(matix);

 int InputNum(string msg)
 {
     Console.Write(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }
*/
/*
 // метод для заполнения двумерного массива
 int[,] FillTwoDimArray(int countRow, int countColumn)
 {
     System.Random numberSyntezator = new System.Random();
     int i = 0; int j = 0;
     int[,] outArray = new int[countRow, countColumn];
     while (i < countRow)
     {
         j = 0;
         while (j < countColumn)
         {
             outArray[i, j] = numberSyntezator.Next(0, 101);
             j++;
         }
         i++;
     }
     return outArray;
 }


 //метод для печати двумерного массива
 void PrintTwoDimArray(int[,] inputArray)
 {
     int i = 0; int j = 0;

     while (i < inputArray.GetLength(0))
     {
         j = 0;
         while (j < inputArray.GetLength(1))
         {
             Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
             //col[new System.Random().Next(0,16)]; 
             Console.Write(inputArray[i, j] + " ");
             Console.ResetColor(); 
             j++;
         }
         //Console.Write("\n");
         Console.WriteLine();
         i++;
     }
 }

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] CreateArray(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int xlen = InputNum("Ваше число столбцов:");
int ylen = InputNum("Ваше число строк:");
int[,] matrix = CreateArray(xlen, ylen);
ShowArray(matrix);
*/
/*
Знакомство с языками программирования (семинары)
Урок 6. Одномерные массивы. Продолжение..
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();

 List<int> numbers = new List<int>();
 Console.WriteLine("Input numbers(enter empty string to complete):");
 string input;
 while ((input = Console.ReadLine()) !="")
 {
    int number = Convert.ToInt32(input);
    numbers.Add(number);
 }
 int count = 0;
 foreach (int number in numbers)
 {
    if (number > 0)
    {
     count++;   
    }
 }
 Console.WriteLine($"Number of numbers greater than zero => {count}");
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
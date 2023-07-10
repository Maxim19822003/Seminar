/*
Знакомство с языками программирования (семинары)
Урок 9. Рекурсия
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
string ReturnRealDigits(int startNum, int number){ 
    if(startNum == number) return startNum.ToString(); 
    return startNum + " " + ReturnRealDigits(startNum - 1,number); 
} 

Console.Clear(); 
Console.WriteLine(ReturnRealDigits(8,1));
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int Sum(int M, int N){
    if(M > N)
        return 0;
        return M + Sum(M + 1, N);
}
Console.Clear(); 
Console.WriteLine(Sum(4,8));
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
A(m, n) = n + 1,                       если m = 0
A(m, n) = A(m - 1, 1),                 если m > 0 и n = 0
A(m, n) = A(m - 1, A(m, n - 1)),       если m > 0 и n > 0
*/
/*
int Akkerman(int m, int n){
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.Clear(); 
Console.WriteLine(Akkerman(3,2));
*/
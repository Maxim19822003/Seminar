/*
Напишите программу, которая будет
принимать на вход два числа и
выводить, является ли второе число
кратным первому. Если число 2 не 
кратно числу 1, то программа
выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 % num1 == 0)
{
Console.WriteLine("Второе число кратно первому числу.");
}
else

if (num1 != 2 && num2 != 1)
{
Console.WriteLine("Остаток от деления второго числа на первое число: "
+ num2 % num1);
}
else
{
Console.WriteLine("Ошибка: второе число равно 2 или первое число равно 1.");
}
*/

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1%num2;
if(result == 0)
{
    Console.WriteLine($"{num1} кратное {num2}");
}
else
{
    Console.WriteLine($"{num1} не кратное {num2}, остаток {result}");
    
}
/*
Знакомство с языками программирования (семинары)
Урок 6. Одномерные массивы. Продолжение..
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
Console.Clear();

Console.WriteLine("Enter numbers separated by spaces:");

string input = Console.ReadLine();
string[] numberStrings = input.Split(' ');

List<int> numbers = new List<int>();

foreach (string numberString in numberStrings)
{
    int number = Convert.ToInt32(numberString);
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

Console.WriteLine($"Number of numbers greater than zero: {count}");

*/
/*
1. Пользователю предлагается вводить числа в одной строке, разделенные 
пробелами.
2. Считывается введенная строка с помощью `Console.ReadLine()`.
3. С помощью метода `Split(' ')` входная строка разбивается на 
отдельные числа, которые сохраняются в массиве `numberStrings`.
4. Создается пустой список `numbers`.
5. С помощью цикла `foreach` перебираются все элементы массива 
`numberStrings`.
6. Каждая строка с числом преобразуется в целое число с помощью 
`Convert.ToInt32()` и добавляется в список `numbers`.
7. Далее происходит проверка чисел и подсчет количества чисел больше 
нуля.
8. Наконец, выводится количество чисел, больше нуля, на консоль.
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
b1, k1, b2 и k2 задаются пользователем.
Допольнительно нужно проверить на параллельность или совпадение прямых.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.Clear();

Console.WriteLine("Enter values b1, k1, b2 & k2:");

double b1 = GetDoubleValue("b1");
double k1 = GetDoubleValue("k1");
double b2 = GetDoubleValue("b2");
double k2 = GetDoubleValue("k2");

if (k1 == k2){
    if (b1 == b2)
    {
        Console.WriteLine("Straight lines match");
    }
    else
    {
        Console.WriteLine("Straight lines are parallel and not intersect");
    }
}
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Intersection point: ({x}, {y})");
    }
    
    static double GetDoubleValue(string variableName)
    {
        Console.Write($"{variableName}: ");
        string input = Console.ReadLine();
        return Convert.ToDouble(input);
    }
*/
/*
1. После ввода значений b1, k1, b2 и k2 добавляется проверка на 
равенство коэффициентов k1 и k2. Если они равны, это означает, что 
прямые параллельны.
2. Если коэффициенты k1 и k2 равны, добавляется дополнительная 
проверка на равенство значений b1 и b2. Если они также равны, это 
означает, что прямые совпадают. Если значения b1 и b2 не равны, это 
означает, что прямые параллельны и не пересекаются.
3. Если коэффициенты k1 и k2 не равны, это означает, что прямые 
пересекаются.
*/

//Артём, [07.07.2023 21:19]
/* 
Задача 63: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N. 
N = 5 -> "1, 2, 3, 4, 5" 
N = 6 -> "1, 2, 3, 4, 5, 6" 
*/ 
/*
string ReturnRealDigits(int startNum, int number){ 
    if(startNum == number) return startNum.ToString(); 
    return startNum + " " + ReturnRealDigits(startNum+1,number); // " " 
    //для преобразования всего рядом в string 
} 
Console.Clear(); 
Console.WriteLine(ReturnRealDigits(1,5));
*/
/*
Код представляет функцию `ReturnRealDigits`, которая использует 
рекурсию для возврата строки, содержащей натуральные числа от 
`startNum` до `number`.

Вот построчное объяснение кода:

1. `if(startNum == number) return startNum.ToString();`: В начале 
функции проверяется базовый случай рекурсии. Если `startNum` равно 
`number`, это означает, что мы достигли конечного числа, и функция 
возвращает строковое представление этого числа.

2. `return startNum + " " + ReturnRealDigits(startNum+1,number);`: 
Если мы не достигли конечного числа, то используется рекурсия для 
генерации строки, содержащей следующее число и все числа, которые 
идут после него. `startNum` преобразуется в строку с помощью метода 
`ToString()`, затем добавляется пробел и вызывается рекурсивно 
`ReturnRealDigits` с аргументами `startNum + 1` и `number`. Таким 
образом, каждая рекурсивная итерация добавляет следующее число к строке.

3. `Console.Clear();`: Очищает консоль перед выводом результата.

4. `Console.WriteLine(ReturnRealDigits(1,5));`: Вызывает функцию 
`ReturnRealDigits` с аргументами `1` и `5` и выводит результат в 
консоль.

В итоге, код будет выводить строку "1 2 3 4 5", где числа разделены 
пробелами.
*/
//Артём, [07.07.2023 21:19]
/* 
Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. 
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 5, 6, 7, 8" 
*/ 
/*
string ReturnRealDigits(int number, int startNum){ 
    if(startNum == number) return startNum.ToString(); 
    return startNum + " " + ReturnRealDigits(number, startNum+1); 
} 
Console.Clear(); 
Console.WriteLine(ReturnRealDigits(5,3));
*/
//Артём, [07.07.2023 21:20]
/* 
Задача 69: Напишите программу, которая на вход принимает два числа A 
и B, и возводит число А в целую степень B с помощью рекурсии. 
A = 3; B = 5 -> 243 (3⁵) 
A = 2; B = 3 -> 8 
*/ 
/*
int GetPowNumber (int number, int pow){ 
    if(pow == 0) return 1;  
        return number * GetPowNumber(number, pow-1); 
} 
Console.Clear(); 
Console.WriteLine(GetPowNumber(3,1));
*/
/*
Код представляет функцию `GetPowNumber`, которая использует рекурсию 
для вычисления степени числа.

Вот построчное объяснение кода:

1. `if(pow == 0) return 1;`: В начале функции проверяется базовый 
случай рекурсии. Если `pow` равно 0, это означает, что мы достигли 
степени 0, и функция возвращает 1. В степени 0 любое число, кроме 
нуля, равно 1.

2. `return number * GetPowNumber(number, pow-1);`: Если мы не достигли 
степени 0, то используется рекурсия для вычисления степени числа. 
Функция `GetPowNumber` вызывается рекурсивно с аргументами `number` и 
`pow-1`, что означает уменьшение степени на 1. Затем текущее число 
умножается на результат рекурсивного вызова. Это происходит до тех пор, 
пока не будет достигнут базовый случай (степень станет равной 0).

3. `Console.Clear();`: Очищает консоль перед выводом результата.

4. `Console.WriteLine(GetPowNumber(3,1));`: Вызывает функцию 
`GetPowNumber` с аргументами `3` и `1` и выводит результат в консоль.

В данном случае, код будет выводить число 3, так как вызов 
`GetPowNumber(3,1)` соответствует вычислению степени 3 в степени 1, 
что равно 3^1 = 3.
*/
//Anastasiya Silvestrova, [07.07.2023 21:20]
/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/
/*
Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

void Print(int m, int n){
    Console.WriteLine(m);
    if(m < n) Print(m+1, n);
}
Print(m, n);
*/
//Anastasiya Silvestrova, [07.07.2023 21:20]
/*
Задача 69: Напишите программу, которая на вход принимает два числа 
A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
/*
Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int Print(int m, int n){
    if(n == 0) return 1;
    return m * Print(m, n-1);
}
Console.WriteLine(Print(m, n));
*/
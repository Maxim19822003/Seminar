/*
Задача 39.Переворот одномерного массива
*/
/*
int [] CreatArray(int size, int min, int max){
    int [] array = new int [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max+1);
    } 
    return array;


}

string Print (int [] array){
    return string.Join(", ", array);
}

void Reverse (int [] array){

    int size = array.Length;
    for (int i = 0, j = size-1; i < j; i++, j--)
    {
        (array[i],array[j]) = (array[j],array[i]);
    }

}

int[] array = CreatArray(7, -9, 9);
Console.WriteLine($"Init array is: [{Print(array)}]");
Reverse(array);
Console.WriteLine($"Reverse array is: [{Print(array)}]");
*/
/*
Давайте рассмотрим этот код по строчкам:

int[] CreatArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }

    return array;
}


- Функция `CreatArray` принимает три параметра: `size` (размер массива),
`min` (минимальное значение случайных чисел) и `max` (максимальное 
значение случайных чисел).
- Создается массив `array` заданного размера `size`.
- Создается экземпляр класса `Random` для генерации случайных чисел.
- В цикле `for` происходит заполнение массива случайными числами в 
диапазоне от `min` до `max` с помощью метода `Next` объекта `rand`.
- После заполнения массива, он возвращается в качестве результата 
функции.

string Print(int[] array)
{
    return string.Join(", ", array);
}

- Функция `Print` принимает один параметр - массив `array`.
- С помощью метода `Join` класса `string`, массив `array` преобразуется 
в строку, где элементы массива разделены запятой и пробелом.
- Результат преобразования в виде строки возвращается.

void Reverse(int[] array)
{
    int size = array.Length;
    for (int i = 0, j = size - 1; i < j; i++, j--)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}

- Функция `Reverse` принимает один параметр - массив `array`.
- Создается переменная `size`, которая хранит длину массива.
- В цикле `for` происходит обмен значений элементов массива `array` с 
помощью кортежа и счетчиков `i` и `j`. Первый элемент массива меняется 
с последним, второй с предпоследним и так далее до середины массива.

int[] array = CreatArray(7, -9, 9);
Console.WriteLine($"Init array is: [{Print(array)}]");
Reverse(array);
Console.WriteLine($"Reverse array is: [{Print(array)}]");


- Создается массив `array`, вызывая функцию `CreatArray` с параметрами 
`7`, `-9` и `9`. Таким образом, создается массив из 7 элементов со 
случайными числами в диапазоне от -9 до 9.
- Выводится исходный массив, используя функцию `Print`.
- Вызывается функция `Reverse` для разворота массива.
- Выводится развернутый массив, снова используя функцию `Print`.

В результате на консоль выводится исходный массив и развернутый массив.
*/
/*
Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон.
*/
/*
Console.Clear();
int GetNumber(string description){

    int number;
    Console.WriteLine($"{description} => ");

    while(true){
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
    
}
int a = GetNumber("Input number: ");
int b = GetNumber("Input number: ");
int c = GetNumber("Input number: ");

bool FindTriangle(int a, int b, int c){
    if((a < b+c) && (b < a+c) && (c < a+b)) return true;
    else return false;
}

string answer = FindTriangle(a, b, c) ? "Yes" : "No";
Console.WriteLine(answer);
*/
/*
Давайте разберем этот код по строчкам:

Console.Clear();
Console.Clear() используется для очистки консоли перед выводом новых 
данных. Это позволяет создавать чистый вывод без предыдущего 
содержимого консоли.

int GetNumber(string description)
{
    int number;
    Console.WriteLine($"{description} => ");

    while (true)
    {
        string temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
}
GetNumber - это функция, которая принимает один параметр description 
(описание числа).
Функция выводит на консоль описание числа и ожидает ввода пользователя.
В цикле while выполняется следующее:
Ввод пользователя считывается с помощью Console.ReadLine() и 
сохраняется в переменную temp.
Происходит попытка преобразования строки temp в целое число с помощью 
int.TryParse(). Результат преобразования сохраняется в переменной 
number.
Если преобразование прошло успешно, то число number возвращается из 
функции.
Если преобразование не удалось, выводится сообщение об ошибке, и цикл 
продолжается, запрашивая у пользователя ввод числа снова.

int a = GetNumber("Input number: ");
int b = GetNumber("Input number: ");
int c = GetNumber("Input number: ");
Создаются переменные a, b и c, в которые сохраняются числа, 
полученные с помощью вызова функции GetNumber. Каждый вызов функции 
сопровождается описанием числа для пользователя.

bool FindTriangle(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b))
        return true;
    else
        return false;
}
FindTriangle - это функция, которая принимает три параметра: 
a, b и c - числа для проверки.
Функция проверяет условие треугольника: если каждая сторона меньше 
суммы двух других сторон, то возвращается true, иначе false.

string answer = FindTriangle(a, b, c) ? "Yes" : "No";
Console.WriteLine(answer);
Создается переменная answer, которая получает значение "Yes" или "No" 
в зависимости от результата вызова функции FindTriangle(a, b, c).
Оператор ? используется для условной проверки: если результат вызова 
FindTriangle(a, b, c) равен true, то значение переменной answer будет 
"Yes", иначе - "No".
Затем значение answer выводится на консоль с помощью Console.WriteLine.
В итоге программа выполняет следующие шаги:

Очищает консоль с помощью Console.Clear().
Запрашивает три числа (a, b, c) от пользователя с помощью функции 
GetNumber(), которая проверяет правильность ввода.
Проверяет условие существования треугольника с помощью функции 
FindTriangle(), которая возвращает true, если треугольник с заданными 
сторонами может существовать, и false в противном случае.
Выводит на консоль "Yes", если треугольник может существовать, и "No" 
в противном случае.
Таким образом, программа позволяет пользователю ввести три числа и 
определить, может ли треугольник с такими сторонами существовать.
*/
/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
/* 
Console.Clear();
int GetNumber(string description){

    int number;
    Console.Write($"{description} => ");

    while(true){
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }    
}
int number = GetNumber("Input number: ");

string FindByteNumber(int number){
    string i = String.Empty;
    while(number > 0){
        i = i.Insert(0, Convert.ToString(number%2));
        number/= 2;
    }
    return i;   
}

string a = FindByteNumber(number);
Console.WriteLine(a);
*/
/*
Давайте разберем этот код по строчкам:

int number = GetNumber("Input number: ");

- В этой строке переменной `number` присваивается значение, полученное 
с помощью вызова функции `GetNumber`. Функция `GetNumber` ожидает ввода 
числа от пользователя с описанием "Input number:", а затем возвращает 
это число.

string FindByteNumber(int number)
{
    string i = String.Empty;
    while (number > 0)
    {
        i = i.Insert(0, Convert.ToString(number % 2));
        number /= 2;
    }
    return i;
}

- `FindByteNumber` - это функция, которая принимает один параметр 
`number` - число, для которого нужно найти двоичное представление.
- Внутри функции происходит следующее:
  - Создается пустая строка `i`, которая будет содержать двоичное 
  представление числа.
  - В цикле `while` выполняется следующее:
    - Пока `number` больше 0:
      - Вычисляется остаток от деления `number` на 2 с помощью 
      оператора `%`.
      - Полученный остаток конвертируется в строку с помощью 
      `Convert.ToString()` и добавляется в начало строки `i` 
      с помощью `i.Insert(0, ...)`.
      - Затем `number` делится на 2 с помощью оператора `/=` 
      для перехода к следующему разряду двоичного числа.
  - После завершения цикла полученная строка `i` содержит двоичное 
  представление числа, и она возвращается из функции.

string a = FindByteNumber(number);
Console.WriteLine(a);

- Создается переменная `a`, которая получает значение, возвращенное из 
функции `FindByteNumber` для числа `number`.
- Затем значение переменной `a` выводится на консоль с помощью 
`Console.WriteLine`, отображая двоичное представление введенного числа.

Таким образом, программа запрашивает у пользователя число, 
затем находит его двоичное представление с помощью функции 
`FindByteNumber` и выводит его на консоль.
*/
/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
/*
Console.Clear();
int GetNumber(string description){

    int number;
    Console.Write($"{description} => ");

    while(true){
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
    
}
int n = GetNumber("Input number: ");

List<int> list = new List<int>();
list.Add(0);
list.Add(1);

for(int i = 2; i < n; i++){
    list.Add(list[i-1]+list[i-2]);
}

Console.WriteLine($"[{string.Join(", ", list)}]");
*/
/*
Давайте разберем этот код по строчкам:

int n = GetNumber("Input number: ");

- В этой строке переменной `n` присваивается значение, полученное 
с помощью вызова функции `GetNumber`. Функция `GetNumber` ожидает 
ввода числа от пользователя с описанием "Input number:", а затем 
возвращает это число.

List<int> list = new List<int>();
list.Add(0);
list.Add(1);

- Создается список (коллекция) `list`, который будет содержать 
последовательность чисел Фибоначчи.
- В список добавляются два начальных элемента чисел Фибоначчи: 0 и 1.

for (int i = 2; i < n; i++)
{
    list.Add(list[i - 1] + list[i - 2]);
}

- В этом цикле `for` происходит генерация последовательности чисел 
Фибоначчи.
- Итерация начинается с `i = 2`, так как первые два элемента (0 и 1) 
уже добавлены в список.
- Цикл выполняется, пока `i` меньше `n`, которое представляет 
количество чисел Фибоначчи, которые нужно сгенерировать.
- В каждой итерации выполняется следующее:
  - К текущему элементу списка `list[i]` добавляется сумма двух 
  предыдущих элементов `list[i - 1]` и `list[i - 2]`.
  - Таким образом, каждый следующий элемент списка вычисляется как 
  сумма двух предыдущих элементов.

Console.WriteLine($"[{string.Join(", ", list)}]");

- В этой строке результат сгенерированной последовательности чисел 
Фибоначчи выводится на консоль.
- С помощью `string.Join(", ", list)` элементы списка `list` 
объединяются в строку, разделенную запятыми и с пробелом.
- Затем строка обрамляется в квадратные скобки и выводится на консоль 
с помощью `Console.WriteLine`.

Таким образом, программа запрашивает у пользователя число `n`, 
затем генерирует последовательность чисел Фибоначчи до `n` и 
выводит ее на консоль.
*/
/*
Задача 45: Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.
*/
/*
int[] CreateArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int[] array = CreateArray(5, 0, 10);
Console.WriteLine($"Our list [{string.Join(", ", array)}]");


int[] CopyArray (int[] array){
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] copyArray = CopyArray(array);
Console.WriteLine($"Copy list[{string.Join(", ", copyArray)}]");
*/
/*
Давайте разберем этот код по строчкам:

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
В этой части кода определена функция CreateArray, которая принимает 
три параметра: size (размер массива), min (минимальное значение 
элементов) и max (максимальное значение элементов).
Внутри функции происходит следующее:
Создается новый массив array заданного размера size.
В цикле for происходит заполнение массива случайными числами в 
диапазоне от min до max.
Для каждого индекса i в массиве вызывается метод Next у нового объекта 
Random(), чтобы сгенерировать случайное число в указанном диапазоне и 
присвоить его элементу массива array[i].
После завершения цикла массив array содержит сгенерированные случайные 
числа.
Функция возвращает созданный массив array.

int[] array = CreateArray(5, 0, 10);
Console.WriteLine($"Our list [{string.Join(", ", array)}]");
В этой части кода создается массив array, вызывая функцию 
CreateArray с аргументами 5, 0 и 10.
Затем массив array выводится на консоль с помощью Console.WriteLine и 
string.Join, чтобы показать пользователю содержимое массива.

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}
В этой части кода определена функция CopyArray, которая принимает один 
параметр array - исходный массив, который нужно скопировать.
Внутри функции происходит следующее:
Создается новый массив copyArray с тем же размером, что и исходный 
массив array.
В цикле for происходит копирование элементов из исходного массива 
array в новый массив copyArray.
Каждый элемент array[i] копируется в соответствующий элемент 
copyArray[i].
После завершения цикла массив copyArray содержит копию элементов 
исходного массива array.
Функция возвращает созданный массив copyArray.

int[] copyArray = CopyArray(array);
Console.WriteLine($"Copy list[{string.Join(", ", copyArray)}]");
В этой части кода создается массив copyArray вызывая
функцию CopyArray с аргументом array, который является исходным
массивом.

Затем массив copyArray выводится на консоль с помощью Console.WriteLine 
и string.Join, чтобы показать пользователю содержимое скопированного 
массива.
Таким образом, в данном коде определены две функции: CreateArray, 
которая создает массив с заданным размером и заполняет его случайными 
числами в указанном диапазоне, и CopyArray, которая создает копию 
исходного массива. Затем созданные массивы выводятся на консоль для 
отображения их содержимого. Это может быть полезно, например, при 
проверке работы функции копирования массива или для создания случайных 
тестовых данных.
*/
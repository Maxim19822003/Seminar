/*
Знакомство с языками программирования (семинары)
Урок 5. Функции и одномерные массивы
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int [] CreateArray(int min, int max){  
    int [] array = new int [5]; 
    Random rand = new Random(); 
 
    for (int i = 0; i < 5; i++) 
    { 
        array [i] = rand.Next(min, max+1); 
    } 
 
    return array; 
} 
 
int GetEveN(int [] array){ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] %2 == 0){ 
            count+=1; 
        }  
    } 
    return count; 
} 

int [] arr = CreateArray(100, 999); 
int count = GetEveN(arr); 
Console.WriteLine($"[{string.Join(", ", arr)}]"); 
Console.WriteLine($"Even-number => {count}");
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int [] CreateArray(int size, int min, int max){ 
    int [] array = new int [size]; 
    Random rand = new Random();
     for (int i = 0; i < size; i++) 
    { 
        array [i] = rand.Next(min, max+1); 
    }  
    Console.WriteLine($"[{string.Join(", ", array)}]"); 
    return array;  
}
int GetNotEven(int [] array){ 
    int sum = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] %2 != 0){ 
            sum += array[i];
             
        }  
    } 
    
    return sum;
} 

int [] arr = CreateArray(4, -100, 100);
int sum = GetNotEven(arr);
Console.WriteLine(sum);
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите 
разницу между 
максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
/* 
Console.Write("Input count array: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a){
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble();
        Console.Write($"{randomArray[i]:F2} ");
    }

}

double raz(double[] randomArray){
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length){
        if (max < randomArray[i])
        max = randomArray[i];
        if (min > randomArray[i])
        min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

mas (a);
Console.Write($"Differens max/min: {raz(randomArray):F2}");
*/
//Этот код выполняет следующие действия:

Console.Write("Input count array: "); //- Выводит на консоль сообщение, 
//запрашивающее ввод количества элементов массива.

int a = Convert.ToInt32(Console.ReadLine()); //- Читает введенное 
//пользователем значение и преобразует его в целочисленный тип int, 
//сохраняя в переменную a. Это значение будет использоваться для 
//определения размера массива randomArray.

double[] randomArray = new double[a]; //- Создает новый массив 
//randomArray типа double с размером, определенным пользователем в 
//переменной a.

void mas(int a); //- Объявляет метод mas с параметром a, который 
//используется для заполнения массива случайными значениями.

Random rand = new Random(); //- Создает новый объект класса Random, 
//который будет использоваться для генерации случайных чисел.

for (int i = 0; i < a; i++) //- Начинает цикл, который будет 
//выполняться a раз, где i - переменная-счетчик.

randomArray[i] = rand.NextDouble(); //- Генерирует случайное число с 
//плавающей запятой от 0.0 до 1.0 и сохраняет его в элементе массива 
//randomArray[i].

Console.Write($"{randomArray[i]:F2} "); //- Выводит значение 
//randomArray[i] на консоль с форматированием до двух знаков после 
//запятой.

double raz(double[] randomArray) //- Объявляет метод raz, принимающий 
//массив randomArray в качестве параметра. Этот метод будет 
//использоваться для вычисления разницы между максимальным и 
//минимальным значениями в массиве.

double min = randomArray[0]; //- Инициализирует переменную min 
//значением первого элемента массива randomArray.

double max = randomArray[0]; //- Инициализирует переменную max 
//значением первого элемента массива randomArray.

int i = 1; //- Инициализирует переменную-счетчик i значением 1.

while (i < randomArray.Length) //- Запускает цикл while, который будет 
//выполняться до тех пор, пока значение i меньше длины массива 
//randomArray.

if (max < randomArray[i]) max = randomArray[i]; //- Проверяет, если 
//текущий элемент randomArray[i] больше значения max, то присваивает 
//значение max этому элементу.

if (min > randomArray[i]) min = randomArray[i]; //- Проверяет, если 
//текущий элемент randomArray[i] меньше значения min, то присваивает 
//значение min этому элементу.

i = i + 1; //- Увеличивает значение переменной-счетчика i на 1 перед 
//следующей итерацией цикла while.

return max - min; //- Возвращает разницу между переменными max и min в 
//методе raz.

mas(a); //- Вызывает метод mas и передает ему значение a. Этот метод 
//заполняет массив randomArray случайными значениями.

Console.Write($"Differens max/min: {raz(randomArray):F2}"); //- Выводит 
//на консоль строку, содержащую разницу между максимальным и 
//минимальным значениями в массиве randomArray. Метод raz вызывается с 
//аргументом randomArray, а форматирование :F2 указывает, что значение 
//должно быть отформатировано с двумя знаками после запятой.

//Как результат, этот код запрашивает у пользователя количество 
//элементов в массиве, затем заполняет массив случайными значениями и 
//выводит на консоль разницу между максимальным и минимальным 
//значениями в массиве.
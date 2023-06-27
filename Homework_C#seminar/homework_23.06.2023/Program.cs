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
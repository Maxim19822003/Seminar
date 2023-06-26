/*
Задача 31: Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна 
-20.
*/
/*
Console.Clear();

int [] CreateArray(int size, int min, int max){
    int [] array = new int [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
       array[i] = rand.Next(min, max+1); 
    }
    return array;
}

string Print(int [] array){

    return string.Join(",", array);
}

(int sumNegName, int sumPosName) FindNegPos(int [] array){
    int sumNeg = 0;
    int sumPos = 0;
    foreach (int el in array)
    {
        sumPos += el > 0 ? el:0;
        sumNeg += el < 0 ? el:0;   
    }
    return (sumNegName: sumNeg, sumPosName: sumPos);
}

int [] array = CreateArray(12, -9, 9);
Console.WriteLine(Print(array));

var tuple = FindNegPos(array);
Console.WriteLine(tuple);
*/
/*
Задача 32: Напишите программу замена элементов массива: положительные
 элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
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
 
 
void ReverseDigints (int [] array){ 
 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i]*=-1;  
    } 
    Console.WriteLine($"[{string.Join(", ", array)}]"); 
} 
 
int[] arr = CreateArray(10,-10,10); 
ReverseDigints(arr);
*/
/*
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
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
 
bool SearchNumber (int number, int [] array){ 
    for (int i = 0; i < array.Length; i++) 
    { 
        if(array[i] == number){ 
            return true; 
        } 
    } 
    return false; 
} 
 
int number = 4; 
int [] arr = CreateArray(10,0,4); 
 
string answer = SearchNumber(number, arr) ? "yes" : "no"; 
 
Console.WriteLine(answer);
*/
/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите
 количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте
 для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
int [] CreateArray(int min, int max){ 
    int [] array = new int [123]; 
    Random rand = new Random(); 
 
    for (int i = 0; i < 123; i++) 
    { 
        array [i] = rand.Next(min, max+1); 
    } 
 
    return array; 
} 
 
int GetDigits(int [] array){ 
    int count =0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] >= 10 && array[i] <= 99){ 
            count+=1; 
        }  
    } 
    return count; 
} 
 
int [] arr = CreateArray(0,200); 
int count = GetDigits(arr); 
Console.WriteLine($"[{string.Join(", ", arr)}]"); 
Console.WriteLine($"Digits number = {count}");
*/
/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой
 считаем первый и последний элемент, второй и предпоследний и т.д. 
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
/*
int [] CreateArray(int size, int min, int max){ 
    int [] array = new int [size]; 
    Random rand = new Random(); 
 
    for (int i = 0; i < size; i++) 
    { 
        array [i] = rand.Next(min, max+1); 
    } 
 
    return array; 
} 
 
int [] CreateNewArray(int [] array){ 
    int size = array.Length/2; 
    if (array.Length%2 == 1){ 
        size+=1; 
    } 
    int [] newArray = new int [size]; 
    for (int i = 0, j = array.Length-1; i<=j; i++, j--) 
    { 
        if (i == j){ 
            newArray[i] = array [i]; 
            return newArray; 
        } 
            newArray[i] = array[i]*array[j];  
    } 
    return newArray; 
} 
 
int [] arr = CreateArray(5,0,10); 
Console.WriteLine($"[{string.Join(", ", arr)}]"); 
int [] newArr = CreateNewArray(arr); 
Console.WriteLine($"[{string.Join(", ", newArr)}]");
*/
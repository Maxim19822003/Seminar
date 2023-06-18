/*
Знакомство с языками программирования (семинары)
Урок 3. Базовые алгоритмы. Продолжение
Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
void Print(string text)
{
    Console.WriteLine(text);
}

int GetIntNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return result;
}

Print("Input one by one x1, y1, x2, y2, z1, z2:");
int x1 = GetIntNumber();
int y1 = GetIntNumber();
int z1 = GetIntNumber();
int x2 = GetIntNumber();
int y2 = GetIntNumber();
int z2 = GetIntNumber();

double result = FindDistance(x1, y1, z1, x2, y2, z2);
Print($"Distance between points is: {result} ");
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
int RandomNumber(int min, int max){
    int result = new Random().Next(min, max+1);

    return result;
}
void Print (string text){
    Console.WriteLine(text);
}

void GetSquare(int rand){
    for (int i=1; i<=rand; i++ ){
        Console.Write($"{Math.Pow(i,3)} ");
    }
    
}

int rand = RandomNumber(1, 10);
Print($"{rand}");
GetSquare(rand);
*/
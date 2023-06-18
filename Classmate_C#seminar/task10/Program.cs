/*
Задача №17. Напишите программу, которая
 принимает на вход координаты точки (X и Y),
 причём X = 0, Y = 0 и выдаёт номер четверти
 плоскости, в который находится точка. 
*/
/*
string data = "data";
string error = "error";
string result = "result";

void Print(string text, string arg){
    switch (arg)
    {
        case "data": Console.ForegroundColor = ConsoleColor.Yellow;
        break;

        case "result": Console.ForegroundColor = ConsoleColor.Green;
        break;
        
        case "error": Console.ForegroundColor = ConsoleColor.Red;
        break;
    }
    Console.WriteLine(text);
    Console.ResetColor();
}

int GetIntNum(){
    
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void FindQuarter(int x, int y){
    if(x == 0 || y == 0){
        Print("Our or both coordinate equal 0", error);
    }
    else{
        switch((x, y)){
            case(>0, >0): Print("First quarter.", result);
            break;

            case(<0, >0): Print("Second quarter.", result);
            break;

            case(<0, <0): Print("Third quarter.", result);
            break;

            case(>0, <0): Print("Fourth quarter.", result);
            break;

            
        }
    }
}
Print("Input X coordinate", data);
int coordinateX = GetIntNum();

Print("Input Y coordinate", data);
int coordinateY = GetIntNum();

//Print($"Our coordinate: X = {coordinateX}, Y = {coordinateY}", data);
FindQuarter(coordinateX, coordinateY);
*/
/*
Задача №18. Напишите программу, которая по заданному
номеру четверти будет выдавать диапазон
возможных координат точек в этой четверти
(x и y).
*/
/*
void Print (string text){    
    Console.WriteLine(text);
}
int GetIntNumber(){
    int number = Convert.ToInt32(Console.ReadLine());    
    return number;
}
void FindCoordinate (int number){    
    if (number > 0 && number < 5){
            switch (number)
        {   case 1: Print("X > 0, Y > 0");
            break;
            case 2: Print("X < 0, Y > 0");            
            break;
            case 3: Print("X < 0, Y < 0");
            break;
            case 4: Print("X > 0, Y < 0");            
            break;
        }
        }    
    else{        Print("Insert correct number");
    }}
Print("Input quarter");
int number = GetIntNumber();
FindCoordinate(number);
*/
/*
Напишите программу, которая принимает
 на вход координаты двух точек и 
 находит расстояние между ними в 2D 
 пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
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
double FindDistance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return result;
}

Print("Input one by one x1, y1, x2, y2:");
int x1 = GetIntNumber();
int y1 = GetIntNumber();
int x2 = GetIntNumber();
int y2 = GetIntNumber();

double result = FindDistance(x1, y1, x2, y2);
Print($"Distance between points is: {result} ");
*/
/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
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
        Console.Write($"{Math.Pow(i,2)} ");
    }
    
}

int rand = RandomNumber(1, 10);
Print($"{rand}");
GetSquare(rand);
*/
/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int GetNumber(string description)
{

    int number;
    Console.Write($"{description} =>");
    while (true)
    {
        string temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again =>");
    }
    Console.WriteLine(GetNumber("Input number => "));


}

/*
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*
int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int DigitsNuber(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10; // Отбрасываем последнюю цифру, меняем разрядность.
        count++;
    }
    return count;
}

int number = GetNumber();
int count = DigitsNuber(number);

Console.WriteLine($"Number of digits is {count}");
*/
/*
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
int number = GetNumber("Input number: ");

int count = (int)Math.Log10(number)+1;
Console.WriteLine(count);
*/
/*
Задача 28: Напишите программу, которая принимает на вход число
N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

/*
int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetMultiplication(int number)
{
    int mult = 1; 
    for (int i = 1; i <= number; i++)
    {
        mult *= i;
    }
    return mult;
}

int number = GetNumber();
int mult = GetMultiplication(number);

Console.WriteLine($"Result is {mult}");
*/

/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

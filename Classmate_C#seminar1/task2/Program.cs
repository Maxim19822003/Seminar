/*
День недели по номеру:
3 -> среда
*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Dictionary<int, string> map = new Dictionary<int, string>()
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресение!!!"}
};
if (n > 0 && n < 8)
{
    Console.WriteLine(map[n]);
}
else
{
    Console.WriteLine($"Ошибка!");
}



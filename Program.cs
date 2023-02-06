// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int GetFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(message);
    Console.ResetColor();
    int data = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    return data;
}

int GetStrSum(int start, int finish)
{
    if(start==finish)
    {
        return start;
    }
    return start + GetStrSum(start + 1, finish);
}

int userNumberStart = GetFromUserData("Введите значение начала ряда: ");
int userNumberFinish = GetFromUserData("Введите значение конца ряда: ");

int start = Math.Min(userNumberStart, userNumberFinish);
int finish = Math.Max(userNumberStart, userNumberFinish);

int sum = GetStrSum(start, finish);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {start} до {finish} = {sum}.");
Console.WriteLine();

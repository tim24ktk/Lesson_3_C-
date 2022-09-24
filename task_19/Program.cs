/*
    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    14212 -> нет

    12821 -> да

    23432 -> да
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine($"{prefix} {value}");
}

string PolyTest(int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
        return "полиндром";
    else
        return "не полиндром";
}

int number = ReadData("Введите пятизначное число: ");
string answer = "";

if ((number.ToString()).Length == 5)
    answer = PolyTest(number);
else
    answer = "не соответствует условию задачи!";

PrintData($"Число {number}", answer);
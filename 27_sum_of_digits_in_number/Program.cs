// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ShowOutput(int x)
{
    x = Math.Abs(x);
    int count = 0;
    while (x > 0)
    {
        count = count + x % 10; // count++;
        x = x / 10; // x/=10;
    }
    return count;
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите число N: ");
int result = ShowOutput(x); // лучше вынести это отдельно вот так, потому что потому
Console.WriteLine($"Сумма цифр в числе {x} равно {result}");
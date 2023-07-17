// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void ShowToThePower(int a, int b)
{
    int result = a;
    if (b > 0)
    {
        for (int i = 2; i <= b; i++)
        {
            result = result * a;
        }
        Console.WriteLine($"Числа {a} в степени {b} равно: {result}");
    }
    else if (b == 0)
    {
        result = 1;
        Console.WriteLine($"Числа {a} в степени {b} равно: {result}");
    }
    else Console.WriteLine($"Число {b} - ненатуральное.");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInput("Введите число A: ");
int b = GetInput("Введите натуральное число B: ");

ShowToThePower(a, b);
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Power(int powerBase, int degree)
{
    int power = 1;
    for(int i = 0; i < degree; i++)
    {
        power *= powerBase;
    }
    return power;
}

int number1 = ReadInt("Введите первое число");
int number2 = ReadInt("Введите второе число");
System.Console.WriteLine(Power(number1, number2));
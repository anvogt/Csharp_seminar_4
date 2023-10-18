// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Sum(int number)
{
    int sumResult = 0;
    while(number > 0)
    {
        sumResult += number%10;
        number /= 10;
    }
    return sumResult;

}

int num = ReadInt("Введите число");
System.Console.WriteLine(Sum(num));
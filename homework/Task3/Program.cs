/*
    Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
    и показывает наибольшую цифру числа.
*/

Random randNum = new Random();
int value = randNum.Next(10, 100);
Console.WriteLine($"Сравниваем цифры числа: {value}");
int firstNumValue = value / 10;
int secondNumValue = value % 10;
if (firstNumValue > secondNumValue)
{
    Console.WriteLine($"первая цифра - {firstNumValue} больше");
}
else
{
    if (firstNumValue == secondNumValue)
    {
        Console.WriteLine($"цифры числа {value} равны");
    }
    else
    {
        Console.WriteLine($"вторая цифра - {secondNumValue} больше");
    }
}
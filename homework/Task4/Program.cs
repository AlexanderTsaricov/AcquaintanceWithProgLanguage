/*
    Напишите программу, которая на вход принимает натуральное число N, 
    а на выходе показывает его цифры через запятую.
*/
Console.WriteLine("Введите натуральное число");
int value = Convert.ToInt32(Console.ReadLine());
int writeWalue = value;
while (writeWalue > 0)
{
    Console.Write($"{writeWalue % 10}");
    if (writeWalue > 9)
    {
        Console.Write(", ");
    }
    writeWalue = writeWalue / 10;
}
/*
	Напишите программу, которая выводит третью с
	конца цифру заданного числа или сообщает, что третьей цифры нет

	Примеры:

	456 => 6
	7812 => 1
	91 => Третьей цифры нет
*/

int num = new Random().Next(10, 12000);
Console.WriteLine(num);

if (num > 99)
{
	while(num >= 1000)
	{
		num = num/10;
	}
	Console.WriteLine(num%10);
} else
{
	Console.WriteLine("Третьей цифры нет");
}
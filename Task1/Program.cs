/* Напишите программу, которая принимает на
вход трехзначное число и удаляет вторую цифру 
этого числа */

// а = 256 => 26
// a = 891 => 81

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000) 
{ 
	int num1 = num/100; //Получим первое число
	int num3 = num%10; // Получим второе число (остаток - последнее число)

	int result =  num1*10 + num3;
	Console.WriteLine(result);
}
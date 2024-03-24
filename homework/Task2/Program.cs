/*
    Напишите программу, которая принимает на вход координаты точки (X и Y), 
    причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
    в которой находится эта точка.
*/


Console.WriteLine("Введите координату X не равную 0:");
int coordinateX = Convert.ToInt32(Console.ReadLine());
if (coordinateX != 0)
{
    Console.WriteLine("Введите координату Y не равную 0:");
    int coordinateY = Convert.ToInt32(Console.ReadLine());
    if (coordinateY != 0)
    {
        if (coordinateX > 0 && coordinateY > 0)
        {
            Console.WriteLine("1 координатная четверть");
        }
        if (coordinateX < 0 && coordinateY > 0)
        {
            Console.WriteLine("2 координатная четверть");
        }
        if (coordinateX < 0 && coordinateY < 0)
        {
            Console.WriteLine("3 координатная четверть");
        }
        if (coordinateX > 0 && coordinateY < 0)
        {
            Console.WriteLine("4 координатная четверть");
        }
    }
    else
    {
        Console.WriteLine("Координата Y не должна быть ровна 0");
    }
}
else
{
    Console.WriteLine("Координата Х не должна быть ровна 0");
}
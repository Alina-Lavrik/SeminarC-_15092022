/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру. 
3 -> Среда
5 ->  Пятница*/

Console.WriteLine("Введите день недели: ");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine($"День {day} это Понедельник");
}
if (day == 2)
{
    Console.WriteLine($"День {day} это Вторник");
}
if (day == 3)
{
    Console.WriteLine($"День {day} это Среда");
}
if (day == 4)
{
    Console.WriteLine($"День {day} это Четверг");
}
if (day == 5)
{
    Console.WriteLine($"День {day} это Пятница");
}
if (day == 6)
{
    Console.WriteLine($"День {day} это Суббота");
}
if (day == 7)
{
    Console.WriteLine($"День {day} это Воскресенье");
}


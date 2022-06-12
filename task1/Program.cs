/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.
*/
Console.Write("Введите первое число:");
string value1 = Console.ReadLine();
Console.Write("Введите второе число:");
string value2 = Console.ReadLine();

int value1Int = int.Parse(value1);
int value2Int = int.Parse(value2);

if (value1Int == value2Int)
{
    Console.WriteLine($"Первое число {value1} равно второму числу {value2}");
}
else if (value1Int > value2Int)
{
    Console.WriteLine($"Первое число {value1} больше второго числа {value2}");
}
else
{
    Console.WriteLine($"Первое число {value1} меньше второго числа {value2}");
}

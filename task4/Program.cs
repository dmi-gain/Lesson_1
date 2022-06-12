/*Задача 4: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("Введите число N:");
string value = Console.ReadLine();

int valueInt = int.Parse(value);

int index = 2;

while (index < valueInt || index == valueInt)
{
    if (index % 2 == 0)
    {
        int result = index;
        Console.WriteLine($"{result}");
    }
    index++;
}





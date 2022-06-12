/*
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.Write("Введите число:");
string value = Console.ReadLine();

int valueInt = int.Parse(value);

if (valueInt % 2 == 0)
{
    Console.WriteLine($"Число {valueInt} - чётное");
}
else
{
    Console.WriteLine($"Число {valueInt} - нечётное");
}


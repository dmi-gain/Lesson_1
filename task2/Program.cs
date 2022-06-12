/*Задача 2: Напишите программу, которая принимает на вход
 три числа и выдаёт максимальное из этих чисел.
*/

Console.Write("Введите первое число:");
string value1 = Console.ReadLine();
Console.Write("Введите второе число:");
string value2 = Console.ReadLine();
Console.Write("Введите третье число:");
string value3 = Console.ReadLine();

int value1Int = int.Parse(value1);
int value2Int = int.Parse(value2);
int value3Int = int.Parse(value3);
int valueMax = value1Int;


if (value1Int > value2Int) {
    valueMax = value1Int;
        } else {
        valueMax = value2Int;
}  

if (value3Int > valueMax) {
    valueMax = value3Int;
}

Console.WriteLine($"Число {valueMax} максимальное из введенных трех чисел");


       
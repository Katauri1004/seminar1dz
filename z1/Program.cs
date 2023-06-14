//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7 // a = 2 b = 10 -> max = 10 //a = -9 b = -3 -> max = -3

Console.Write("Введите целое число A ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите целое число Б ");
int num2 = int.Parse(Console.ReadLine());
if (num1>num2)
{
    Console.Write($"Большее число - {num1}, меньшее число - {num2}");
}
else
{
    Console.Write($"Большее число - {num2}, меньшее число - {num1}");
}

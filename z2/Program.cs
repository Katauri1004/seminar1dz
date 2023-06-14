// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 2, 3, 7 -> 744 5 78 -> 7822 3 9 -> 22
Console.Write("Введите число A ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число Б ");
int numB = int.Parse(Console.ReadLine());
Console.Write("Введите число C ");
int numC = int.Parse(Console.ReadLine());
if (numA>numB)
{
    Console.Write($"Наибольшее число -  {numA}");
}
else if (numC>numA)
{
    Console.Write($"Наибольшее число - {numC}");
}
else
{
    Console.Write($"Наибольшее число - {numB}");
}
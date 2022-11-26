// Напишите программу, которая на вход принимает 2 числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число > ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
Console.Write("Введите второе число > ");
string num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);
if (number1 > number2)
{
    System.Console.Write("Максимальное число = " + number1 + " Минимальное число = " + number2);
}
else
{
    System.Console.Write("Максимальное число = " + number2 + " Минимальное число = " + number1);
}

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число > ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
Console.Write("Введите второе число > ");
string num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);
Console.Write("Введите третье число > ");
string num3 = Console.ReadLine();
int number3 = Convert.ToInt32(num2);
if (number1 >= number2 && number1 >= number3)
{
    System.Console.Write("Максимальное число = " + number1);
}
else if (number2 >= number3)
{
     System.Console.Write("Максимальное число = " + number2);
}
else
{
    System.Console.Write("Максимальное число = " + number3);
}
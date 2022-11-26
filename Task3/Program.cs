// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число > ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
if (number1 % 2 == 0)
{
    System.Console.Write("Число  " + number1 + " чётное");
}
else
{
    System.Console.Write("Число  " + number1 + " нечётное");
}
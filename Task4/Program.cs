// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N > ");
string num1 = Console.ReadLine();
int N = Convert.ToInt32(num1);
string Even = "Четные числа: ";
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Even = Even + " " + i;
    i++;
    }
    else
    {
    i++;
    }
}
System.Console.Write (Even);
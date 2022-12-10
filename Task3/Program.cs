// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Phrase(string message)

{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int number = Phrase("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}


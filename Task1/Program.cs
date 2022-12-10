// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
int Phrase(string message)

{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = Phrase("Введите пятизначное число для проверки: ");
 if(number >= 10000 && number < 100000)
    {
        int i = number / 10000;
        int j = number % 10;
 
            if(i == j)
            {
                number = number / 10;
                int i2 = (number / 100) % 10;
                int j2 = number % 10;
                if(i2 == j2)
                    Console.WriteLine("Введенное число палиндром");
            }
            else 
            Console.WriteLine("Введенное число не палиндром");
            
    }
    else
    {
        Console.WriteLine("Некорректное число!");
    }
    

 
